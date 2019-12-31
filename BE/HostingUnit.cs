using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        #region Properties

        public long HostingUnitKey;
        public Host Owner;
        public string HostingUnitName;
        public bool[,] Diary = new bool[12, 31];
        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
