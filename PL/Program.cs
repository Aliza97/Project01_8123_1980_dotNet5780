using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
//using BE;
namespace PL
{
    class Program
    {
        static BL.IBL bl = BL.FactoryBL.GetBL();
        static void Main(string[] args)
        {
            BE.GuestRequest guest1 = new BE.GuestRequest
            {
                GuestRequestKey = 20000345,
                PrivateName = "Sarah",
                FamilyName = "Rottenberg",
                MailAddress = "sararott@gmail.com",
                StatusRequest = BE.MyEnums.StatusRequest.Active,
                RegistrationDate = new DateTime(2019, 09, 20),
                EntryDate = new DateTime(2019, 10, 12),
                ReleaseDate = new DateTime(2019, 10, 18),
                Area = BE.MyEnums.Area.South,
                SubArea = "Dead Sea",
                Type = BE.MyEnums.Type.Zimmer,
                Adults = 2,
                Children = 0,
                Pool = BE.MyEnums.Pool.Possible,
                Jacuzzi = BE.MyEnums.Jacuzzi.Possible,

            };
            try
            {
                bl.AddGuestRequest((BE.GuestRequest)guest1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            BE.Host host1 = new BE.Host()
            {
                HostKey = 10000367,
                PrivateName = "Samuel",
                FamilyName = "Cohen",
                PhoneNumber = 0582042589,
                MailAddress = "samcohen@gmail.com",
                BankBranchDetails = new BE.BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" },
                BankAccountNumber = 31231,
                CollectionClearance = true
            };
            BE.Host host2 = new BE.Host()
            {
                HostKey = 10000368,
                PrivateName = "Dina",
                FamilyName = "Schwartz",
                PhoneNumber = 0584567822,
                MailAddress = "schwartd@gmail.com",
                BankBranchDetails = new BE.BankBranch { BankNumber = 0001, BankName = "leumi", BranchNumber = 335, BranchAdress = "hapisga 10", BranchCity = "jerusalem" },
                BankAccountNumber = 31421,
                CollectionClearance = true,
            };
            /*= new BE.HostingUnit()*/
            BE.HostingUnit unit1 = new BE.HostingUnit();

            unit1.HostingUnitKey = 30000005;
            unit1.Owner = host1;
            unit1.HostingUnitName = "The house 1";
            unit1.subArea = "Nahlaos";
            unit1.jaccuzi = true;
            unit1.garden = true;
            unit1.childrenAttractions = true;
            unit1.kids = 2;
            unit1.area = BE.MyEnums.Area.Jerusalem;
            unit1.pool = true;
            unit1.adults = 3;

            try
            {
                //bl.AddBE.HostingUnit(new BE.HostingUnit {

                //HostingUnitKey = 30000005,
                //Owner = host1,
                //HostingUnitName = "The house 1",
                //subArea = "Nahlaos",
                //jaccuzi = true,
                //garden = true,
                //childrenAttractions = true,
                //kids = 2,
                //area = BE.MyEnums.Area.Jerusalem,
                //pool = true,
                //adults = 3
                //});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        BE.HostingUnit unit2 = new BE.HostingUnit()
        {                  //10000000
            HostingUnitKey = 30000057,
                Owner = host2,
                HostingUnitName = "The house 2",
                area = BE.MyEnums.Area.Jerusalem,
                pool = false,
                adults = 5,
                jaccuzi = true,
                garden = true,
                childrenAttractions =false,
                kids = 1,
            };

            try
            {
                bl.AddHostingUnit(new BE.HostingUnit
                {                  //10000000
                    HostingUnitKey = 30000057,
                    Owner = host2,
                    HostingUnitName = "The house 2",
                    area = BE.MyEnums.Area.Jerusalem,
                    pool = false,
                    adults = 5,
                    jaccuzi = true,
                    garden = true,
                    childrenAttractions = false,
                    kids = 1,
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            BE.HostingUnit unit3 = new BE.HostingUnit()
            {
                HostingUnitKey = 30000456,
                Owner = host1,
                HostingUnitName = "The house 3",
                subArea = "Tel aviv",
                jaccuzi = true,
                garden = true,
                childrenAttractions = false,
                area = BE.MyEnums.Area.Center,
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

         




            BE.GuestRequest guest2 = new BE.GuestRequest()
            {
                GuestRequestKey = 20000567,
                PrivateName = "Stephane",
                FamilyName = "Ross",
                MailAddress = "stephanr@icloud.com",
                StatusRequest = BE.MyEnums.StatusRequest.Active,
                EntryDate = new DateTime(2019, 11, 15),
                ReleaseDate = new DateTime(2019, 11, 20),
                Area = BE.MyEnums.Area.Center,
                Type = BE.MyEnums.Type.Appartment,
                Adults = 2,
                Children = 3,
                Garden = BE.MyEnums.Garden.Possible,
                ChildrenAttractions = BE.MyEnums.ChildrenAttractions.Possible,
            };

            try
            {
                bl.AddGuestRequest(guest2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            BE.GuestRequest guest3 = new BE.GuestRequest()
            {
                GuestRequestKey = 20000890,
                PrivateName = "Esti",
                FamilyName = "Rozen",
                MailAddress = "estirozen@hotmail.com",
                   StatusRequest = BE.MyEnums.StatusRequest.Active,
                RegistrationDate = new DateTime(2019, 05, 15),
                EntryDate = new DateTime(2019, 07, 06),
                ReleaseDate = new DateTime(2019, 07, 15),
                Area = BE.MyEnums.Area.North,
                Type = BE.MyEnums.Type.Camping,
                Adults = 4,
            };


            BE.Order order1 = new BE.Order()
            {
                CreateDate = new DateTime(2019, 07, 15),
                GuestRequestKey = 20000890,
                HostingUnitKey = 123456,
                Status = BE.MyEnums.Status.NotRelevent,
            };

            BE.Order order2 = new BE.Order()
            {
                CreateDate = new DateTime(2019, 04, 12),
                GuestRequestKey = 20000345,
                HostingUnitKey = 123456,
                Status = BE.MyEnums.Status.NotRelevent,
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
                    bl.UpdateOrder(order, BE.MyEnums.Status.MailHasBeenSent);
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
                    bl.UpdateOrder(order, BE.MyEnums.Status.Refused);
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
                    bl.UpdateOrder(order, BE.MyEnums.Status.Accepted);
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
            //    foreach (var BE.Host unit1 in bl.GetAllHostingUnits())
            //        Console.WriteLine(bl.NumOfSuccessfulOrders(unit1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
        
    }
}
