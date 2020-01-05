using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace BL
{
    public class BL : IBL
    {
        #region CheckingFunctions
        bool CheckValidDate(GuestRequest g, DateTime entry, DateTime release)
        {
            int result = DateTime.Compare(entry, release);
            if (result > 0)
                return false;
            else return true;
        }
        bool CheckBankAuthorization(Host host)
        {
            return host.CollectionClearance;
        }
        bool CheckFreeDate(HostingUnit h, DateTime entry, DateTime release)
        {
            bool flag = false;
            int help = entry.Month;
            int help2 = entry.Day;
            int days = NumDays(entry, release);
            for (int i = 0; i < days; help2++, i++)
                if (h.Diary(help, help2) == true)
                    flag = false;

            if (help2 == 30)
                help2 = 1;
            help++;

            return flag;
        }
        bool AfterCloseStatus(Order o)
        {
            if (o.Status == Myenums.Status.TransactionClosedThroughTheSite)
                throw new Exception("the status is already close impossible to change");
            return true;
        }
        int IfChangeStatus(Order o)
        {
            List<GuestRequest> guestRequest = getGuestRequests(x => x.GuestRequestKey == order.GuestRequestKey);
            GuestRequest request = guestRequest.Find(x => x.GuestRequestKey == order.GuestRequestKey);
            return Configuration.minPrice * NumOfDays(request.entry, request.release)
        }
        void UpdateDiary(Order o) { }
        void ChangesAfterCloseTransaction(Order o, string Status) { }
        bool HUisInUse(Order o)
        {
            if (o.Status == myEnums.Status.Closed)
                throw new ExceptionBL("The order is already closed");
            return true;
        }
        bool PermissionBankIsInUse(Host host) { }

        void SentMail(Order o, string Status) { Console.WriteLine("an email has been sent"); }
        #endregion
        #region PrintFunc
        List<HostingUnit> AvailableHostingUnits(DateTime entry, int daysholidays);//return all valids HostingUnit
        int NumDays(DateTime begining, DateTime end); // returns the days from the first day till the hend
        int NumDays(DateTime begining); //returns the day from the begining day till now
        List<Order> PrintDaysOrder(int days); // return a list of orders that a mail has been sent from the num of days
        List<GuestRequest> MatchRequests(Predicate<GuestRequest> predicate); // returns all request that match a certain property
        int NumSentOrders(GuestRequest g); //return the number of orders sent to a client
        int NumOfSuccessfulOrders(HostingUnit h);// returns the number of orders that closed successfuly for that hosting unit


        #endregion
    }
}