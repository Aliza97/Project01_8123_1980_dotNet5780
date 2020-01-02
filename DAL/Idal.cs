using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE; 
namespace DAL
{
    public interface Idal
    {
        #region GuestRequest
        void addGuestRequest(GuestRequest g); // add a guest request
        void updateGestRequest(GuestRequest g); // update a guestrequest
        GuestRequest GetGuestRequest(long GuestRequestKey);
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null);
        #endregion

        #region  HostingUnit
        void addHostingUnit(HostingUnit h); // add yehidat irouah
        void deleteHostingUnit(HostingUnit h); // delete yehidat irouah
        void updateHostingUnit(HostingUnit h); //update yehidat irouah
        HostingUnit GetHostingUnit(long HostingUnitKey);
        IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null);
        #endregion

        #region Order
        void addOrder(Order o);
        void updateOrder(Order o);
        Order GetOrder(long OrderKey); // to get an order
        IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null);
        #endregion

        #region bankbranch
        IEnumerable<BankBranch> GetAllBanks(Func<BankBranch, bool> predicat = null);
        #endregion

    }
}
