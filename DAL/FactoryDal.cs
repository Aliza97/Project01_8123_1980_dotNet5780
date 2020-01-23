using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactoryDal
    {
        public static Idal getDal(string typeDAL)
        {
            switch (typeDAL)
            {
                case "List": return DALList.Instance;
                default: return null;
            }

        }


    }
}
