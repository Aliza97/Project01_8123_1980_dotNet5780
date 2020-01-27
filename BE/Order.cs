using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        
        #region Properties
        public long HostingUnitKey { get ; set; }
        public long GuestRequestKey { get; set; }
        public long OrderKey { get; set; }
        public MyEnums.Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }
        #endregion
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
