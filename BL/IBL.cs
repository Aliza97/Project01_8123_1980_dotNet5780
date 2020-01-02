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
        int addHostingUnit(HostingUnit h);//Add a hosting unit
        void DeleteHostingUnit(HostingUnit h);//Removing a hosting unit
        void UpdateHostingUnit(HostingUnit h);//Hosting unit update
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null);
        HostingUnit GetHostingUnit(long HostingUnitKey);
        #endregion

        #region GuestRequest
        int addGuestRequest(GuestRequest g);//Add a customer requirement
        void UpdateGuestRequest(GuestRequest g);//Customer Requirement Status Update
        GuestRequest GetGuestRequest(long GuestRequestKey);
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null);
        #endregion

        #region Order
        int AddOrder(Order o);//Add an invitation
        void UpdateOrder(Order o);//Update Order Status
        Order GetOrder(long OrderKey); // to get an order
        IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null);


        #endregion
        #endregion

        #region CheckingFunctions 
        void CheckValidDate(GuestRequest g, DateTime entry,DateTime release); //entry date at least a day before the release date
        bool CheckBankAuthorization(Host host); // if authorization to debit from the bankaccount..
        bool CheckFreeDate(HostingUnit h,DateTime entry, DateTime release); // check if the date of guestrequest are free for yehidat iruah
        void AfterCloseStatus(Order o,string Status);// can't chane anymore the status if close
        void IfChangeStatus(Order o,string Status); // if the status change , has to pay 10shkl per day
        void UpdateDiary(Order o, string Status); // if the status changes, update the diary
        void ChangesAfterCloseTransaction(Order o, string Status); // if the status changes, change status guestrequest and all other status of client
        bool HUisInUse(HostingUnit h);// check if in use in case we want to erase hostingunit
        bool PermissionBankIsInUse(Host host); // doesnt allow to revoke bank prelvment if in use
        void SentMail(Order o, string Status); // when the status is on sentmail, send an email to the client with details
        #endregion

        #region PrintFunc
        List<HostingUnit> AvailableHostingUnits(DateTime entry, int daysholidays);//return all valids HostingUnit 
        List<>






        #endregion
    }
}