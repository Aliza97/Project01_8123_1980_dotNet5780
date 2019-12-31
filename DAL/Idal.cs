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
        void addGuestRequest(GuestRequest g); // add a guest request
        void updateGestRequest(GuestRequest g); // update a guestrequest
        void addHostingUnit(HostingUnit h); // add yehidat irouah
        void deleteHostingUnit(HostingUnit h); // delete yehidat irouah
        void updateHostingUnit(HostingUnit h); //update yehidat irouah
        void addOrder(Order o);
        void updateOrder(Order o);
        IEnumerable<GuestRequest> GetAllRequests(Func<GuestRequest, bool> predicat = null);
        IEnumerable<HostingUnit> GetAllHostingUnits(Func<HostingUnit, bool> predicat = null);

        IEnumerable<Order> GetAllOrders(Func<Order, bool> predicat = null);
        IEnumerable<BankBranch> GetAllBanks(Func<BankBranch, bool> predicat = null);

    }
}
