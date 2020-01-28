using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        #region Dalfunctions
        #region HostingUnit
        void AddHostingUnit(HostingUnit h);//Add a hosting unit
        void DeleteHostingUnit(long h);//Removing a hosting unit
        void UpdateHostingUnit(HostingUnit h);//Hosting unit update
        IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null);
        HostingUnit GetHostingUnit(long HostingUnitKey);

        #endregion

        #region GuestRequest
        void AddGuestRequest(GuestRequest g);//Add a customer requirement
        void UpdateGuestRequest(GuestRequest g);//Customer Requirement Status Update
        GuestRequest GetGuestRequest(long GuestRequestKey);
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null);
        #endregion

        #region Order
        void AddOrder(Order o);//Add an invitation
        void UpdateOrder(Order o, MyEnums.Status s);//Update Order Status
        Order GetOrder(long OrderKey); // to get an order
        IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null);


        #endregion
        #endregion

        #region CheckingFunctions 
        bool CheckValidDate(GuestRequest g, DateTime entry, DateTime release); //entry date at least a day before the release date
        bool CheckBankAuthorization(Host host); // if authorization to debit from the bankaccount..
        bool CheckFreeDate(HostingUnit h, DateTime entry, DateTime release); // check if the date of guestrequest are free for yehidat iruah
        bool AfterCloseStatus(Order o);// can't chane anymore the status if close
        int IfChangeStatus(Order o); // if the status change , has to pay 10shkl per day
        void UpdateDiary(Order o); // if the status changes, update the diary
        void ChangesAfterCloseTransaction(Order o); // if the status changes, change status guestrequest and all other status of client
        bool HUisInUse(Order o);// check if in use in case we want to erase hostingunit
        bool HUhasOpenOrder(HostingUnit h); // check if the hosting has an open order
        bool PermissionBankIsInUse(Host host); // doesnt allow to revoke bank prelvment if in use
        void SentMail(Order o, string s); // when the status is on sentmail, send an email to the client with details
        #endregion

        #region PrintFunc
        List<HostingUnit> AvailableHostingUnits(DateTime entry, int daysholidays);//return all valids HostingUnit 
        int NumDays(DateTime begining, DateTime end); // returns the days from the first day till the hend
        int NumDays(DateTime begining); //returns the day from the begining day till now
        List<Order> PrintDaysOrder(int days); // return a list of orders that a mail has been sent from the num of days
        List<GuestRequest> MatchRequests(Func<GuestRequest, bool> predicate); // returns all request that match a certain property
        int NumSentOrders(GuestRequest g); //return the number of orders sent to a client
        int NumOfSuccessfulOrders(HostingUnit h);// returns the number of orders that closed successfuly for that hosting unit


        #endregion
        #region Grouping
        IEnumerable<IGrouping<Enum, GuestRequest>> GroupByArea();
        IEnumerable<IGrouping<int, GuestRequest>> GroupByVacationners();
        IEnumerable<IGrouping<Host, HostingUnit>> GroupHostByHostingUnit();
        IEnumerable<IGrouping<MyEnums.Area, HostingUnit>> GroupHostingUnitByArea();

        #endregion
    }

}