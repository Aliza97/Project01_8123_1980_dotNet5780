using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
namespace DAL
{
    public class Dal_imp : Idal
    {

        public DataSource d;
        public Dal_imp() { d = new DS.DataSource(); }

        #region guestrequest
        public GuestRequest GetGuestRequest(long GestRequestKey)
        {
            return DS.DataSource.guestrequestList.FirstOrDefault(s => s.GestRequestKey == GestRequestKey);
        }
        public void addGuestRequest(GuestRequest g)
        {
            if (g.GestRequestKey < 10000000 || g.GestRequestKey > 99999999)
                throw new Exception("this GuestRequestKey isn't correct");
            GuestRequest help = GetGuestRequest(g.GestRequestKey);
            if (help != null)
                throw new Exception("this GuestRequestKey already exists");
            DS.DataSource.guestrequestList.Add(g);
        }
        public void updateGestRequest(GuestRequest g)
        {



        }

        public IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null)
        {
            if (predicat == null)
                return DS.DataSource.guestrequestList.AsEnumerable();
            return DS.DataSource.guestrequestList.Where(predicat);
        }


        #endregion
        #region HostingUnit
        public HostingUnit GetHostingUnit(long HostingUnitKey)
        {
            return DS.DataSource.traineeList.FirstOrDefault(s => s.HostingUnitKey == HostingUnitKey);
        }
        public void addHostingUnit(HostingUnit h)
        {
            if (h.HostingUnitKey < 10000000 || h.HostingUnitKey > 99999999)
                throw new Exception("this HostingUnitKey isn't correct");
            HostingUnit help = GetHostingUnit(h.HostingUnitKey);
            if (help != null)
                throw new Exception("this HostingUnitKey already exists");
            DS.DataSource.hostingunitList.Add(h);
        }
        public void deleteHostingUnit(long HostingUnitKey)
        {
            HostingUnit help = GetHostingUnit(HostingUnitKey);
            if (help == null)
                throw new Exception("this id doesn't exist");
            DS.DataSource.hostingunitList.Remove(help);
        }
        public void updateHostingUnit(HostingUnit h)
        {

        }
        public IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null)
        {

            if (predicat == null)
                return DS.DataSource.hostingunitList.AsEnumerable();
            return DS.DataSource.hostingunitList.Where(predicat);
        }
        #endregion
        #region order
        public void addOrder(Order o)
        {
            if (o.OrderKey < 10000000 || o.OrderKey > 99999999)
                throw new Exception("this OrderKey isn't correct");
            Order help = GetHostingUnit(o.OrderKey);
            if (help != null)
                throw new Exception("this OrderKey already exists");
            DS.DataSource.orderList.Add(o);
        }
        public void updateOrder(Order o)
        {


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
            return;
        }
    }
}
