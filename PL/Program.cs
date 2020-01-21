﻿using System;
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
                CollectionClearance = true
            };

            HostingUnit unit1 = new HostingUnit()
            {
                Owner = host1,
                HostingUnitName = "The house 1",
                area = MyEnums.Area.Jerusalem,
                pool = true,
                persons = 3,

            };
            HostingUnit unit2 = new HostingUnit()
            {
                Owner = host2,
                HostingUnitName = "The house 2",
                area = MyEnums.Area.Jerusalem,
                pool = false,
                persons = 2,

            };
            HostingUnit unit3 = new HostingUnit()
            {
                Owner = host1,
                HostingUnitName = "The house 3",
                area = MyEnums.Area.Center,
                pool = true,
                persons = 6,

            };

            GuestRequest guest1 = new GuestRequest()
            {
                GuestRequestKey = 20000345,
                PrivateName = "Sarah",
                FamilyName = "Rottenberg",
                MailAddress = "sararott@gmail.com",
                StatusRequest = MyEnums.StatusRequest.Active.ToString(),
                RegistrationDate = new DateTime(2019, 09, 20),
                EntryDate = new DateTime(2019, 10, 12),
                ReleaseDate = new DateTime(2019, 10, 18),
                Area = MyEnums.Area.South.ToString(),
                SubArea = "Dead Sea",
                Type = MyEnums.Type.Zimmer.ToString(),
                Adults = 2,
                Children = 0,
                Pool = MyEnums.NotSure.Possible.ToString(),
                Jacuzzi = MyEnums.NotSure.Possible.ToString(),

            };




            GuestRequest guest2 = new GuestRequest()
            {
                GuestRequestKey = 20000567,
                PrivateName = "Stephane",
                FamilyName = "Ross",
                MailAddress = "stephanr@icloud.com",
                StatusRequest = MyEnums.StatusRequest.Active.ToString(),
                EntryDate = new DateTime(2019, 11, 15),
                ReleaseDate = new DateTime(2019, 11, 20),
                Area = MyEnums.Area.Center.ToString(),
                Type = MyEnums.Type.Appartment.ToString(),
                Adults = 2,
                Children = 3,
                Garden = MyEnums.NotSure.Possible.ToString(),
                ChildrenAttractions = MyEnums.NotSure.Possible.ToString(),
            };





            GuestRequest guest3 = new GuestRequest()
            {
                GuestRequestKey = 20000890,
                PrivateName = "Esti",
                FamilyName = "Rozen",
                MailAddress = "estirozen@hotmail.com",
                   StatusRequest = MyEnums.StatusRequest.Active.ToString(),
                RegistrationDate = new DateTime(2019, 05, 15),
                EntryDate = new DateTime(2019, 07, 06),
                ReleaseDate = new DateTime(2019, 07, 15),
                Area = MyEnums.Area.North.ToString(),
                Type = MyEnums.Type.Camping.ToString(),
                Adults = 4,
            };
            string choice;
            Console.WriteLine(""
            choice = Console.ReadLine();
        }
        
    }
}
