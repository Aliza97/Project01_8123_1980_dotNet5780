using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        #region bankbranch
        static BankBranch Bank1 = new BankBranch { BankNumber =0001, BankName ="leumi", BranchNumber =335, BranchAdress = "hapisga 10", BranchCity ="jerusalem"};
        static BankBranch Bank2 = new BankBranch { BankNumber =0002, BankName ="bankyerushalaim", BranchNumber =889, BranchAdress = "sarei israel 15", BranchCity ="tel aviv"};
        static BankBranch Bank3 = new BankBranch { BankNumber =0003, BankName ="discount", BranchNumber =779, BranchAdress = "yafo", BranchCity ="rishon letsion"};
        static BankBranch Bank4 = new BankBranch { BankNumber =0004, BankName ="mizrahi", BranchNumber =226, BranchAdress ="ben yehuda", BranchCity ="bet shemesh"};
        static BankBranch Bank5 = new BankBranch { BankNumber =0005, BankName ="poalim", BranchNumber =774, BranchAdress ="levin", BranchCity ="netanya"};
        #endregion
        public static List<GuestRequest> guestrequestList;
        public static List<HostingUnit> hostingunitList=new List<HostingUnit>() { Owner = host2,
                HostingUnitName = "The house 2",
                area = MyEnums.Area.Jerusalem,
                pool = false,
                persons = 2,};
        public static List<Order> orderList;
        public static List<BankBranch> bankbranchesList;
        public DataSource()
        {
            guestrequestList = new List<GuestRequest>();
            hostingunitList = new List<HostingUnit>();
            orderList = new List<Order>();
        }
    }
}
