using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        #region Properties
        public long GuestRequestKey;
        public string PrivateName;
        public string FamilyName;
        public string MailAddress;
        public Enum StatusRequest;
        public DateTime RegistrationDate;
        public DateTime EntryDate;
        public DateTime ReleaseDate;
        public Enum Area;
        public string SubArea;
        public Enum Type;
        public int Adults;
        public int Children;
        public Enum Pool;
        public Enum Jacuzzi;
        public Enum Garden;
        public Enum ChildrenAttractions;

        #endregion
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
