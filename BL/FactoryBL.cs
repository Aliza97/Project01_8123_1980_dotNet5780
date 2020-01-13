using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        public static IBL getBL(string typeBL)
        {
            switch(typeBL)
            {
                case "List": return BL.Instance;
                default: return null;
            }
        }

    }
}
