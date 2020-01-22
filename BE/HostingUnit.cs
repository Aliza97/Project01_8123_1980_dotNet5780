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

        long _HostingUnitKey;
        public long HostingUnitKey { get => _HostingUnitKey; set => value = _HostingUnitKey; }

        Host _Owner;
        public Host Owner { get => _Owner; set => value = _Owner; }

        string _HostingUnitName;
        public string HostingUnitName { get => _HostingUnitName; set => value = _HostingUnitName; }

        private bool[,] diary;
        public bool[,] Diary /*= new bool[12, 31]*/ { get => diary; set => value = diary; }

        MyEnums.Area _area;
        public MyEnums.Area area { get => _area; set => value = _area; }

        string _subArea;
        public string subArea { get => _subArea; set => value = _subArea; }

        bool _pool;
        public bool pool { get => _pool; set => value = _pool; }

        int _persons;
        public int persons { get => _persons; set => value = _persons; }

        int _kids;
        public int kids { get => _kids; set => value = _kids; }

        bool _jaccuzi;
        public bool jaccuzi { get => _jaccuzi; set => value = _jaccuzi; }

        bool _garden;
        public bool garden { get => _garden; set => value = _garden; }

        bool _childrenAttractions;
        public bool childrenAttractions { get => _childrenAttractions; set => value = _childrenAttractions; }

        int _stars;
        public int stars { get => _stars; set => value = _stars; }
    #endregion
    public override string ToString()

        { return this.ToStringProperty(); }
    }
}
