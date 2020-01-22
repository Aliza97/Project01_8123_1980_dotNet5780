using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        long _GuestRequestKey;
        string _PrivateName;
        string _FamilyName;
        string _MailAddress;
        Enum _StatusRequest;
        DateTime _RegistrationDate;
        DateTime _EntryDate;
        DateTime _ReleaseDate;
        Enum _Area;
        string _SubArea;
        Enum _Type;
        int _Adults;
        int _Children;
        Enum _Pool;
        Enum _Jacuzzi;
        Enum _Garden;
        Enum _ChildrenAttractions;


        #region Properties
        public long GuestRequestKey { get => _GuestRequestKey; set => value = _GuestRequestKey; }
        public string PrivateName { get => _PrivateName; set => value = _PrivateName; }
        public string FamilyName { get => _FamilyName; set => value = _FamilyName; }
        public string MailAddress { get => _MailAddress; set => value = _MailAddress; }
        public Enum StatusRequest { get => _StatusRequest; set => value = _StatusRequest; }
        public DateTime RegistrationDate { get => _RegistrationDate; set => value = _RegistrationDate; }
        public DateTime EntryDate { get => _EntryDate; set => value = _EntryDate; }
        public DateTime ReleaseDate { get => _ReleaseDate; set => value = _ReleaseDate; }
        public Enum Area { get => _Area; set => value = _Area; }
        public string SubArea { get => _SubArea; set => value = _SubArea; }
        public Enum Type { get => _Type; set => value = _Type; }
        public int Adults { get => _Adults; set => value = _Adults; }
        public int Children { get => _Children; set => value = _Children; }
        public Enum Pool { get => _Pool; set => value = _Pool; }
        public Enum Jacuzzi { get => _Jacuzzi; set => value = _Jacuzzi; }
        public Enum Garden { get => _Garden; set => value = _Garden; }
        public Enum ChildrenAttractions { get => _ChildrenAttractions; set => value = _ChildrenAttractions; }

        #endregion

        
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
