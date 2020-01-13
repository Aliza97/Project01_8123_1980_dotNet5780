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
        GuestRequest GetGuestRequest(long GuestRequestKey); //to get a guest request
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null); //to get all the requests
        #endregion

        #region  HostingUnit
        void addHostingUnit(HostingUnit h); // add yehidat irouah
        void deleteHostingUnit(long HostingUnitKey); // delete yehidat irouah
        void updateHostingUnit(HostingUnit h); //update yehidat irouah
        HostingUnit GetHostingUnit(long HostingUnitKey); //to get a hosting unit
        IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null); // to get all the hosting unit
        #endregion

        #region Order
        void addOrder(Order o);
        void updateOrder(Order o);
        Order GetOrder(long OrderKey); // to get an order
        IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null); //to get all the orders
        #endregion

        #region bankbranch
        IEnumerable<BankBranch> GetAllBanks(Func<BankBranch, bool> predicat = null); //to get all the snifim
        #endregion

    }
}
