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
        public string StatusRequest;
        public DateTime RegistrationDate;
        public DateTime EntryDate;
        public DateTime ReleaseDate;
        public string Area;
        public string SubArea;
        public string Type;
        public int Adults;
        public int Children;
        public string Pool;
        public string Jacuzzi;
        public string Garden;
        public string ChildrenAttractions;

        #endregion
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
