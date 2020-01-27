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
        public long GuestRequestKey { get; set ; }
        public string PrivateName { get; set; }
        public string FamilyName { get ; set; }
        public string MailAddress { get ; set ; }
        public Enum StatusRequest { get ; set ; }
        public DateTime RegistrationDate { get; set ; }
        public DateTime EntryDate { get ; set ; }
        public DateTime ReleaseDate { get; set ; }
        public Enum Area { get; set ; }
        public string SubArea { get ; set; }
        public Enum Type { get ; set; }
        public int Adults { get; set ; }
        public int Children { get; set; }
        public Enum Pool { get; set; }
        public Enum Jacuzzi { get; set ; }
        public Enum Garden { get ; set ; }
        public Enum ChildrenAttractions { get; set; }

        #endregion

        
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
