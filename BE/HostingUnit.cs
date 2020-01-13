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
        public MyEnums.Area area;
        public string subArea;
        public bool pool;
        public int persons;
        public int kids;
        public bool jaccuzi;
        public bool garden;
        public bool childrenAttractions;
        public int stars;
        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
