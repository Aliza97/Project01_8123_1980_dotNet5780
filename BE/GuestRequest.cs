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
        public Enum Area { get; set /*=> value = _Area*/; }
        public string SubArea { get /*=> _SubArea*/; set/* => value = _SubArea*/; }
        public Enum Type { get /*=> _Type*/; set/* => value = _Type*/; }
        public int Adults { get /*=> _Adults*/; set /*=> value = _Adults*/; }
        public int Children { get /*=> _Children*/; set/* => value = _Children*/; }
        public Enum Pool { get /*=> _Pool*/; set/* => value = _Pool*/; }
        public Enum Jacuzzi { get /*=> _Jacuzzi*/; set /*=> value = _Jacuzzi*/; }
        public Enum Garden { get /*=> _Garden*/; set /*=> value = _Garden*/; }
        public Enum ChildrenAttractions { get/* => _ChildrenAttractions*/; set /*=> value = _ChildrenAttractions*/; }

        #endregion

        
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
