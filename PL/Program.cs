using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
namespace PL
{
    class Program
    {
        static BL.IBL bl = BL.FactoryBL.GetBL();
        static void Main(string[] args)
        {

            Host host1 = new Host()
            {
                HostKey = 10000367,
                PrivateName = "Samuel",
                FamilyName = "Cohen",
                PhoneNumber = 0582042589,
                MailAddress = "samcohen@gmail.com",
                BankBranchDetails = new BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" },
                BankAccountNumber = 31231,
                CollectionClearance = true
            };
            Host host2 = new Host()
            {
                HostKey = 10000368,
                PrivateName = "Dina",
                FamilyName = "Schwartz",
                PhoneNumber = 0584567822,
                MailAddress = "schwartd@gmail.com",
                BankBranchDetails = new BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" },
                BankAccountNumber = 31421,
                CollectionClearance = true,
            };

            HostingUnit unit1 = new HostingUnit()
            {
                HostingUnitKey = 30000005,
                Owner = host1,
                HostingUnitName = "The house 1",
                subArea = "Nahlaos",
                jaccuzi = true,
                garden = true,
                childrenAttractions = true,
                kids = 2,
                area = MyEnums.Area.Jerusalem,
                pool = true,
                adults = 3,
            };

            try
            {
                bl.AddHostingUnit(unit1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        HostingUnit unit2 = new HostingUnit()
        {
            HostingUnitKey = 30000057,
                Owner = host2,
                HostingUnitName = "The house 2",
                area = MyEnums.Area.Jerusalem,
                pool = false,
                adults = 5,
                jaccuzi = true,
                garden = true,
                childrenAttractions =false,
                kids = 1,
            };

            try
            {
                bl.AddHostingUnit(unit2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            HostingUnit unit3 = new HostingUnit()
            {
                HostingUnitKey = 30000456,
                Owner = host1,
                HostingUnitName = "The house 3",
                subArea = "Tel aviv",
                jaccuzi = true,
                garden = true,
                childrenAttractions = false,
                area = MyEnums.Area.Center,
                pool = true,
                adults = 6,

            };
            try
            {
                bl.AddHostingUnit(unit3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach (var unit in bl.GetAllHostingUnits())
            {
                Console.WriteLine(unit);
            }

            GuestRequest guest1 = new GuestRequest()
            {
                GuestRequestKey = 20000345,
                PrivateName = "Sarah",
                FamilyName = "Rottenberg",
                MailAddress = "sararott@gmail.com",
                StatusRequest = MyEnums.StatusRequest.Active,
                RegistrationDate = new DateTime(2019, 09, 20),
                EntryDate = new DateTime(2019, 10, 12),
                ReleaseDate = new DateTime(2019, 10, 18),
                Area = MyEnums.Area.South,
                SubArea = "Dead Sea",
                Type = MyEnums.Type.Zimmer,
                Adults = 2,
                Children = 0,
                Pool = MyEnums.Pool.Possible,
                Jacuzzi = MyEnums.Jacuzzi.Possible,

            };
            try
            {
                bl.AddGuestRequest(guest1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }




            GuestRequest guest2 = new GuestRequest()
            {
                GuestRequestKey = 20000567,
                PrivateName = "Stephane",
                FamilyName = "Ross",
                MailAddress = "stephanr@icloud.com",
                StatusRequest = MyEnums.StatusRequest.Active,
                EntryDate = new DateTime(2019, 11, 15),
                ReleaseDate = new DateTime(2019, 11, 20),
                Area = MyEnums.Area.Center,
                Type = MyEnums.Type.Appartment,
                Adults = 2,
                Children = 3,
                Garden = MyEnums.Garden.Possible,
                ChildrenAttractions = MyEnums.ChildrenAttractions.Possible,
            };

            try
            {
                bl.AddGuestRequest(guest2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            GuestRequest guest3 = new GuestRequest()
            {
                GuestRequestKey = 20000890,
                PrivateName = "Esti",
                FamilyName = "Rozen",
                MailAddress = "estirozen@hotmail.com",
                   StatusRequest = MyEnums.StatusRequest.Active,
                RegistrationDate = new DateTime(2019, 05, 15),
                EntryDate = new DateTime(2019, 07, 06),
                ReleaseDate = new DateTime(2019, 07, 15),
                Area = MyEnums.Area.North,
                Type = MyEnums.Type.Camping,
                Adults = 4,
            };


            Order order1 = new Order()
            {
                CreateDate = new DateTime(2019, 07, 15),
                GuestRequestKey = 20000890,
                HostingUnitKey = 123456,
                Status = MyEnums.Status.NotRelevent,
            };

            Order order2 = new Order()
            {
                CreateDate = new DateTime(2019, 04, 12),
                GuestRequestKey = 20000345,
                HostingUnitKey = 123456,
                Status = MyEnums.Status.NotRelevent,
            };


            try
            {
                bl.AddGuestRequest(guest3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            foreach (var guest in bl.GetAllRequests())
            {
                Console.WriteLine(guest);
            }
            try
            {
                
                bl.UpdateHostingUnit(unit3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                bl.DeleteHostingUnit(unit3.HostingUnitKey);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            foreach (var unit in bl.GetAllHostingUnits())
            {
                Console.WriteLine(unit);
            }

            try
            {
                bl.AddOrder(order1);
                bl.AddOrder(order2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                foreach (var order in bl.GetAllOrders())
                {
                    bl.UpdateOrder(order, MyEnums.Status.MailHasBeenSent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                foreach (var order in bl.GetAllOrders())
                {
                    bl.UpdateOrder(order, MyEnums.Status.Refused);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                foreach (var order in bl.GetAllOrders())
                {
                    bl.UpdateOrder(order, MyEnums.Status.Accepted);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                foreach (var order in bl.GetAllOrders())
                    Console.WriteLine("ORDER: " + order);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            

            try
            {
                Console.WriteLine("number of successful orders that unit has: " + bl.NumOfSuccessfulOrders(unit2));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                foreach (var unit in bl.AvailableHostingUnits(new DateTime(2019, 5, 3), 20))
                {
                    Console.WriteLine("unit is available:" + unit);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("tests of get days function");
            Console.WriteLine(bl.NumDays(new DateTime(2020, 8, 2), new DateTime(2020, 1, 5)));

            Console.WriteLine(bl.NumDays(new DateTime(2020, 1, 2)));


            try
            {
                foreach (var host in bl.GetAllHostingUnits())
                    Console.WriteLine(bl.NumOfSuccessfulOrders(unit1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
        
    }
}
