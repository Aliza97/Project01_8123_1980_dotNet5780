using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public static class Cloning
    {
        public static HostingUnit Clone(this HostingUnit original)
        {
            HostingUnit target = new HostingUnit();
            target.area = original.area;
            target.kids = original.kids;
            target.childrenAttractions = original.childrenAttractions;
            target.Diary = original.Diary;
            target.garden = original.garden;
            target.HostingUnitKey = original.HostingUnitKey;
            target.HostingUnitName = original.HostingUnitName;
            target.jaccuzi = original.jaccuzi;
            target.Owner = original.Owner;
            target.pool = original.pool;
            target.stars = original.stars;
            target.adults = original.adults;
            target.subArea = original.subArea;
            return target;
        }
        public static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest();
            target.Adults = original.Adults;
            target.Area = original.Area;
            target.Children = original.Children;
            target.ChildrenAttractions = original.ChildrenAttractions;
            target.Garden = original.Garden;
            target.Jacuzzi = original.Jacuzzi;
            target.Pool = original.Pool;
            target.FamilyName = original.FamilyName;
            target.GuestRequestKey = original.GuestRequestKey;
            target.MailAddress = original.MailAddress;
            target.PrivateName = original.PrivateName;
            target.RegistrationDate = original.RegistrationDate;
            target.EntryDate = original.EntryDate;
            target.ReleaseDate = original.ReleaseDate;
            target.StatusRequest = original.StatusRequest;
            target.SubArea = original.SubArea;
            target.Type = original.Type;

            return target;
        }
        public static Host Clone(this Host original)
        {
            Host target = new Host();
            target.BankBranchDetails = original.BankBranchDetails;
            target.CollectionClearance = original.CollectionClearance;
            target.FamilyName = original.FamilyName;
            target.PhoneNumber = original.PhoneNumber;
            target.HostKey = original.HostKey;
            target.MailAddress = original.MailAddress;
            target.PrivateName = original.PrivateName;
            target.BankAccountNumber = original.BankAccountNumber;
            return target;
        }

        public static BankBranch Clone(this BankBranch original)
        {
            BankBranch target = new BankBranch();
            target.BankNumber = original.BankNumber;
            target.BankName = original.BankName;
            target.BranchAdress = original.BranchAdress;
            target.BranchCity = original.BranchCity;
            target.BranchNumber = original.BranchNumber;
            return target;
        }
        public static Order Clone(this Order original)
        {
            Order target = new Order();
            target.CreateDate = original.CreateDate;
            target.GuestRequestKey = original.GuestRequestKey;
            target.HostingUnitKey = original.HostingUnitKey;
            target.OrderDate = original.OrderDate;
            target.OrderKey = original.OrderKey;
            target.Status = original.Status;
            return target;
        }
    }
}