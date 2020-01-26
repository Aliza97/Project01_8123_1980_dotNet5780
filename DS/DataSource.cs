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
        static BankBranch Bank1 = new BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" };
        static BankBranch Bank2 = new BankBranch { BankNumber = 0002, BankName = "bankyerushalaim", BranchNumber = 889, BranchAdress = "sarei israel 15", BranchCity = "tel aviv" };
        static BankBranch Bank3 = new BankBranch { BankNumber = 0003, BankName = "discount", BranchNumber = 779, BranchAdress = "yafo", BranchCity = "rishon letsion" };
        static BankBranch Bank4 = new BankBranch { BankNumber = 0004, BankName = "mizrahi", BranchNumber = 226, BranchAdress = "ben yehuda", BranchCity = "bet shemesh" };
        static BankBranch Bank5 = new BankBranch { BankNumber = 0005, BankName = "poalim", BranchNumber = 774, BranchAdress = "levin", BranchCity = "netanya" };
        #endregion
        public static List<GuestRequest> guestrequestList;
        public static List<HostingUnit> hostingunitList;
        public static List<Order> orderList;
        public static List<BankBranch> bankbranchesList;
        static DataSource()
        {
            guestrequestList = new List<GuestRequest>();
            hostingunitList = new List<HostingUnit>();
            orderList = new List<Order>();


            Host host1 = new BE.Host();

            host1.HostKey = 10000367;
            host1.PrivateName = "Samuel";
            host1.FamilyName = "Cohen";
            host1.PhoneNumber = 0582042589;
            host1.MailAddress = "samcohen@gmail.com";
            host1.BankBranchDetails = new BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" };
            host1.BankAccountNumber = 31231;
            host1.CollectionClearance = true;
        



            //Host host2 = new Host();

            //host2.HostKey = 10000368;
            //host2.PrivateName = "Dina";
            //host2.FamilyName = "Schwartz";
            //host2.PhoneNumber = 0584567822;
            //host2.MailAddress = "schwartd@gmail.com";
            //host2.BankBranchDetails = new BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" };
            //host2.BankAccountNumber = 31421;
            //host2.CollectionClearance = true;


            //GuestRequest guest1 = new GuestRequest();

            //guest1.GuestRequestKey = 20000345;
            //guest1.PrivateName = "Sarah";
            //guest1.FamilyName = "Rottenberg";
            //guest1.MailAddress = "sararott@gmail.com";
            //guest1.StatusRequest = MyEnums.StatusRequest.Active;
            //guest1.RegistrationDate = new DateTime(2019, 09, 20);
            //guest1.EntryDate = new DateTime(2019, 10, 12);
            //guest1.ReleaseDate = new DateTime(2019, 10, 18);
            //guest1.Area = MyEnums.Area.South;
            //guest1.SubArea = "Dead Sea";
            //guest1.Type = MyEnums.Type.Zimmer;
            //guest1.Adults = 2;
            //guest1.Children = 0;
            //guest1.Pool = MyEnums.Pool.Possible;
            //guest1.Jacuzzi = MyEnums.Jacuzzi.Possible;
            //guestrequestList.Add(guest1);





            //GuestRequest guest2 = new GuestRequest();


            //guest2.GuestRequestKey = 20000567;
            //guest2.PrivateName = "Stephane";
            //guest2.FamilyName = "Ross";
            //guest2.MailAddress = "stephanr@icloud.com";
            //guest2.StatusRequest = MyEnums.StatusRequest.Active;
            //guest2.EntryDate = new DateTime(2019, 11, 15);
            //guest2.ReleaseDate = new DateTime(2019, 11, 20);
            //guest2.Area = MyEnums.Area.Center;
            //guest2.Type = MyEnums.Type.Appartment;
            //guest2.Adults = 2;
            //guest2.Children = 3;
            //guest2.Garden = MyEnums.Garden.Possible;
            //guest2.ChildrenAttractions = MyEnums.ChildrenAttractions.Possible;
            //guestrequestList.Add(guest2);






            //GuestRequest guest3 = new GuestRequest();

            //guest3.GuestRequestKey = 20000890;
            //guest3.PrivateName = "Esti";
            //guest3.FamilyName = "Rozen";
            //guest3.MailAddress = "estirozen@hotmail.com";
            //guest3.StatusRequest = MyEnums.StatusRequest.Active;
            //guest3.RegistrationDate = new DateTime(2019, 05, 15);
            //guest3.EntryDate = new DateTime(2019, 07, 06);
            //guest3.ReleaseDate = new DateTime(2019, 07, 15);
            //guest3.Area = MyEnums.Area.North;
            //guest3.Type = MyEnums.Type.Camping;
            //guest3.Adults = 4;
            //guestrequestList.Add(guest3);



            //HostingUnit unit1 = new HostingUnit();

            //unit1.HostingUnitKey = 30000005;
            //unit1.Owner = host1;
            //unit1.HostingUnitName = "The house 1";
            //unit1.subArea = "Nahlaos";
            //unit1.jaccuzi = true;
            //unit1.garden = true;
            //unit1.childrenAttractions = true;
            //unit1.kids = 2;
            //unit1.area = MyEnums.Area.Jerusalem;
            //unit1.pool = true;
            //unit1.adults = 3;


            //HostingUnit unit2 = new HostingUnit();

            //unit2.HostingUnitKey = 30000057;
            //unit2.Owner = host2;
            //unit2.HostingUnitName = "The house 2";
            //unit2.area = MyEnums.Area.Jerusalem;
            //unit2.pool = false;
            //unit2.adults = 5;
            //unit1.jaccuzi = true;
            //unit1.garden = true;
            //unit1.childrenAttractions = false;
            //unit1.kids = 1;



            //HostingUnit unit3 = new HostingUnit();

            //unit3.Owner = host1;
            //unit3.HostingUnitName = "The house 3";
            //unit3.area = MyEnums.Area.Center;
            //unit3.pool = true;
            //unit3.adults = 6;





        }
    }
}
