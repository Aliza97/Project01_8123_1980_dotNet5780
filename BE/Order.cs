using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        long _HostingUnitKey;
        long _GuestRequestKey;
        long _OrderKey;
        Enum _Status;
        DateTime _CreateDate;
        DateTime _OrderDate; 

        #region Properties
        public long HostingUnitKey { get => _HostingUnitKey; set => value = _HostingUnitKey; }
        public long GuestRequestKey { get => _GuestRequestKey; set => value = _GuestRequestKey; }
        public long OrderKey { get => _OrderKey; set => value = _OrderKey; }
        public Enum Status { get => _Status; set => value = _Status; }
        public DateTime CreateDate { get => _CreateDate; set => value = _CreateDate; }
        public DateTime OrderDate { get => _OrderDate; set => value = _OrderDate; }
        #endregion
        public override string ToString()
        {
            return this.ToStringProperty();
        }
    }
}
