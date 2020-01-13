using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class MyString
    {
         public static string ToStringProperty<T>(this T t) //pk this?
            {
                string str = "";
                foreach (PropertyInfo item in t.GetType().GetProperties())
                {
                    str += "\n" + item.Name + ": " + item.GetValue(t);
                }
                return str;
            }
        
    }
}
