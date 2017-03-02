using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Factory
    {
        static Compute cp;
        static string realName;
        public static Compute getCalc(string op)
        {
            realName = "calc." + op;
            Factory.cp = getCp();
            return cp;
        }

        private static Compute getCp()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            object obj = assembly.CreateInstance(realName, true);
            return (Compute)obj;
        }
    }
}
