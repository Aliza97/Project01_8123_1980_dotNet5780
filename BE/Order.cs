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
        public long HostingUnitKey;
        public long GuestRequestKey;
        public long OrderKey;
        public string Status;
        public DateTime CreateDate;
        public DateTime OrderDate;
        #endregion
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
