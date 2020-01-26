using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BE;
using DAL;


namespace BL
{
    public class BL : IBL
    {
        static Idal myDAL;
        Idal dal = DAL.FactoryDal.getDal("List");
        //   #region Singleton
        //  private static readonly BL instance = new BL();
        //public static BL Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}
        static BL()
        {
            string TypeDAL = Configuration.TypeDAL;
            myDAL = FactoryDal.getDal(TypeDAL);
        }
        public BL() { }

        //  #endregion

        #region Dalfunctions

        #region HostingUnit
        #region guestrequest
        public GuestRequest GetGuestRequest(long GuestRequestKey)
        {
            return dal.GetGuestRequest(GuestRequestKey);
            //return DS.DataSource.guestrequestList.FirstOrDefault(s => s.GuestRequestKey == GuestRequestKey);
        }
        public void AddGuestRequest(BE.GuestRequest g)
        {
            if (g.GuestRequestKey < 10000000 || g.GuestRequestKey > 99999999)
                throw new Exception("this GuestRequestKey isn't correct");
            GuestRequest help = GetGuestRequest(g.GuestRequestKey);
            if (help != null)
                throw new Exception("this GuestRequestKey already exists");
            if (g == null)
                g.GuestRequestKey = Configuration.GuestRequestKey;
            Configuration.GuestRequestKey++;
            g.StatusRequest = MyEnums.StatusRequest.Active;
            g.RegistrationDate = DateTime.Now;

            DS.DataSource.guestrequestList.Add(g);
        }
        public void UpdateGuestRequest(GuestRequest g)
        {
            try
            {
                dal.UpdateGuestRequest(g);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null)
        {
            if (predicat == null)
                return DS.DataSource.guestrequestList.AsEnumerable();
            return DS.DataSource.guestrequestList.Where(predicat);
        }


        #endregion
        public HostingUnit GetHostingUnit(long HostingUnitKey)
        {
            return dal.GetHostingUnit(HostingUnitKey);
        }
        public void AddHostingUnit(HostingUnit h)
        {
            if (h.HostingUnitKey < 10000000 || h.HostingUnitKey > 99999999)
                throw new Exception("this HostingUnitKey isn't correct");
            HostingUnit help = GetHostingUnit(h.HostingUnitKey);
            if (help != null)
                throw new Exception("this HostingUnitKey already exists");
            DS.DataSource.hostingunitList.Add(h);
        }
        public void DeleteHostingUnit(long HostingUnitKey)
        {
            HostingUnit help = GetHostingUnit(HostingUnitKey);
            if (help == null)
                throw new Exception("this id doesn't exist");
            DS.DataSource.hostingunitList.Remove(help);
        }
        public void UpdateHostingUnit(HostingUnit h)
        {
            try
            {
                dal.UpdateHostingUnit(h);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null)
        {

            if (predicat == null)
                return DS.DataSource.hostingunitList.AsEnumerable();
            return DS.DataSource.hostingunitList.Where(predicat);
        }
        #endregion
        #region order
        public Order GetOrder(long OrderKey)
        {
            return dal.GetOrder(OrderKey);
        }

        public void AddOrder(Order o)
        {
            if (o.OrderKey < 10000000 || o.OrderKey > 99999999)
                throw new Exception("this OrderKey isn't correct");
            Order help = GetOrder(o.OrderKey);
            if (help != null)
                throw new Exception("this OrderKey already exists");
            DS.DataSource.orderList.Add(o);
        }
        public void UpdateOrder(Order o, MyEnums.Status s)
        {
            try
            {


                if (AfterCloseStatus(o) == true)
                {
                    if ((MyEnums.Status)o.Status == MyEnums.Status.Closed)
                    {
                        dal.UpdateOrder(o);
                        UpdateDiary(o);
                        IfChangeStatus(o);
                        ChangesAfterCloseTransaction(o);

                    }
                    else
                    {
                        if ((MyEnums.Status)o.Status == MyEnums.Status.MailHasBeenSent)
                        {
                            IEnumerable<HostingUnit> h = GetAllHostingUnits(x => o.HostingUnitKey == x.HostingUnitKey);
                            HostingUnit u = h.FirstOrDefault((x => o.HostingUnitKey == x.HostingUnitKey));//Y a pas Find ds les Enumerable
                            if (PermissionBankIsInUse(u.Owner) == true)
                            {
                                dal.UpdateOrder(o);
                                SentMail(o);
                            }
                            else
                                throw new Exception("No BankAccount Permission");
                        }
                        else
                        {
                            o.Status = s;
                            dal.UpdateOrder(o);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null)
        {
            if (predicat == null)
                return DS.DataSource.orderList.AsEnumerable();
            return DS.DataSource.orderList.Where(predicat);
        }
        #endregion
        public IEnumerable<BankBranch> GetAllBanks(Func<BankBranch, bool> predicat = null)
        {
            if (predicat == null)
                return DS.DataSource.bankbranchesList.AsEnumerable();
            return DS.DataSource.bankbranchesList.Where(predicat);

        }
        #endregion
        #region CheckingFunctions
        public bool CheckValidDate(GuestRequest g, DateTime entry, DateTime release)
        {
            int result = DateTime.Compare(entry, release);
            if (result > 0)
                return false;
            else return true;
        }
        public bool CheckBankAuthorization(Host host)
        {
            return host.CollectionClearance;
        }
        public bool CheckFreeDate(HostingUnit h, DateTime entry, DateTime release)
        {
            bool flag = false;
            int help = entry.Month;
            int help2 = entry.Day;
            int days = NumDays(entry, release);
            for (int i = 0; i < days; help2++, i++)
                if (h.Diary[help, help2] == true)
                    flag = false;

            if (help2 == 30)
                help2 = 1;
            help++;

            return flag;
        }
        public bool AfterCloseStatus(Order o)
        {
            if (o.Status.Equals(MyEnums.Status.Closed))
                throw new Exception("the status is already close impossible to change");
            return true;
        }


        public int IfChangeStatus(Order o)
        {
            GuestRequest guestRequest = GetGuestRequest(o.GuestRequestKey);
            return Configuration.minPrice * NumDays(guestRequest.EntryDate, guestRequest.ReleaseDate);
        }
        public void UpdateDiary(Order o)

        {
            HostingUnit hostingUnit = GetHostingUnit(o.HostingUnitKey);
            bool[,] diary = hostingUnit.Diary;
            GuestRequest guestRequests = GetGuestRequest(o.GuestRequestKey);
            TimeSpan duration = guestRequests.ReleaseDate - guestRequests.EntryDate;
            int i = guestRequests.EntryDate.Month - 1;
            int j = guestRequests.EntryDate.Day - 1;

            for (int k = 0; k < duration.Days; k++)
            {
                if (j > 30)
                {
                    j = 0;
                    i++;
                }
                diary[i, j] = true;
                j++;
            }
            hostingUnit.Diary = diary;
            UpdateHostingUnit(hostingUnit);


        }
        public void ChangesAfterCloseTransaction(Order o)
        {
            GuestRequest GuestRequest = GetGuestRequest(o.GuestRequestKey);
            GuestRequest.StatusRequest = MyEnums.Status.TransactionClosedThroughTheSite;
            Order ordersforequest = GetOrder(o.GuestRequestKey);

            if ((MyEnums.Status)ordersforequest.Status != MyEnums.Status.Closed)
                ordersforequest.Status = MyEnums.Status.NotRelevent;
        }
        public bool HUisInUse(Order o)
        {
            try
            {
                if ((MyEnums.Status)o.Status == MyEnums.Status.Closed)
                    throw new Exception("The order is already closed");
                return true;
            }
            catch
            {
                throw new Exception();
            }

        }
        public bool PermissionBankIsInUse(Host host)
        {
            IEnumerable<Order> openOrders = GetAllOrders(x => (MyEnums.Status)x.Status == MyEnums.Status.TransactionOpen);
            List<HostingUnit> hostingUnit = null;
            foreach (var order in openOrders)
                hostingUnit.Add(GetHostingUnit(order.HostingUnitKey));
            foreach (var str in hostingUnit)
                if (str.Owner.HostKey == host.HostKey)
                    return false;
            return true;
        }

        private List<Order> GetOrder(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public void SentMail(Order o) { Console.WriteLine("an email has been sent"); }
        #endregion

        #region PrintFunc
        public List<HostingUnit> AvailableHostingUnits(DateTime entry, int daysholidays)
        {

            IEnumerable<HostingUnit> listHostingUnit = dal.GetAllHostingUnits();
            List<HostingUnit> newH = null;
            foreach (HostingUnit h in listHostingUnit)
            {
                if (CheckFreeDate(h, entry, entry.AddDays(daysholidays)))
                    newH.Add(h);


            }
            return newH;

        }
        public int NumDays(DateTime begining, DateTime end)
        {
            return (end - begining).Days;
        }

        public int NumDays(DateTime begining)
        {
            DateTime end = DateTime.Now;
            return (end - begining).Days;
        }
        public List<Order> PrintDaysOrder(int days)
        {
            List<Order> listToReturn = null;

            IEnumerable<Order> listOrders = dal.GetAllOrders();
            foreach (Order ord in listOrders)
            {
                int create = (DateTime.Now - ord.CreateDate).Days;
                int sent = (DateTime.Now - ord.OrderDate).Days;
                if ((days < create) || (days < sent))
                    listToReturn.Add(ord);
            }
            return listToReturn;

        }
        public List<GuestRequest> MatchRequests(Func<GuestRequest, bool> predicate)
        {
            IEnumerable<GuestRequest> guestRequestList = dal.GetAllRequests();
            List<GuestRequest> listMatch = new List<GuestRequest>();
            //if (predicate == null)
            //    return dal.GetAllRequests();
            bool temp = true;
            foreach (GuestRequest str in guestRequestList)
            {
                if ((MyEnums.StatusRequest)str.StatusRequest == MyEnums.StatusRequest.Active)
                {
                    foreach (Predicate<GuestRequest> item in predicate.GetInvocationList())
                    {
                        if (!item(str))
                            temp = false;
                    }
                    if (temp)
                        listMatch.Add(str);
                    temp = true;
                }
            }
            return listMatch;
        }
        public int NumSentOrders(GuestRequest g)
        {
            int count = 0; ;

            IEnumerable<Order> listOrders = dal.GetAllOrders();
            foreach (Order ord in listOrders)
            {
                if (ord.GuestRequestKey == g.GuestRequestKey)
                    count++;
            }
            return count;

        }

        public int NumOfSuccessfulOrders(HostingUnit h)
        {
            int i = 0;
            IEnumerable<Order> listOrders = dal.GetAllOrders();
            foreach (Order ord in listOrders)
            {
                if (ord.HostingUnitKey == h.HostingUnitKey)
                    i++;
            }
            return i;
        }
        #endregion

        #region Grouping
        public IEnumerable<IGrouping<Enum, GuestRequest>> GroupByArea()
        {
            IEnumerable<GuestRequest> listGuestRequest = dal.GetAllRequests();
            var groupToReturn = from request in listGuestRequest
                                group request by request.Area;
            return groupToReturn;
        }
        public IEnumerable<IGrouping<int, GuestRequest>> GroupByVacationners()
        {

            IEnumerable<GuestRequest> listGuestRequest = dal.GetAllRequests();
            var groupToReturn = from request in listGuestRequest
                                group request by (request.Children + request.Adults);
            return groupToReturn;
        }
        public IEnumerable<IGrouping<Host, HostingUnit>> GroupHostByHostingUnit()
        {
            IEnumerable<HostingUnit> listHostingUnit = dal.GetAllHostingUnits();
            IEnumerable<IGrouping<Host, HostingUnit>> groupToReturn = from str in listHostingUnit
                                                                      group str by str.Owner;
            return groupToReturn;
        }
        public IEnumerable<IGrouping<MyEnums.Area, HostingUnit>> GroupHostingUnitByArea()
        {
            IEnumerable<HostingUnit> listHostingUnit = dal.GetAllHostingUnits();
            var groupToReturn = from str in listHostingUnit
                                group str by str.area;
            return groupToReturn;
        }

        #endregion
    }
}
