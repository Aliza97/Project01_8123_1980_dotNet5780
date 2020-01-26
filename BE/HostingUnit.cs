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
        public long HostingUnitKey { get; set; }   
        public Host Owner { get; set; }  
        public string HostingUnitName { get ; set; }
        public bool[,] Diary = new bool[12, 31];
        public MyEnums.Area area { get; set ; }
        public string subArea { get; set; }
        public bool pool { get ; set ; }
        public int adults { get; set; }
        public int kids { get; set ; }
        public bool jaccuzi { get ; set ; } 
        public bool garden { get ; set ; }
        public bool childrenAttractions { get; set; }
        public int stars { get ; set; }
    #endregion
    public override string ToString()

        { return this.ToStringProperty(); }
    }
}
