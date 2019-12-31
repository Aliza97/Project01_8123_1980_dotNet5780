using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    { public static List<GuestRequest> guestrequestList;
        public static List<HostingUnit> hostingunitList;
        public static List<Order> orderList;

        public DataSource()
        {
            guestrequestList = new List<GuestRequest>();
            hostingunitList = new List<HostingUnit>();
            orderList = new List<Order>();
        }
    }
}
