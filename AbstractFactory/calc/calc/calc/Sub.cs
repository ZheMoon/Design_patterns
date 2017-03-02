using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Sub:Compute
    {
        public override double GetResult()
        {
            Result = Num1 - Num2;
            return Result;
        }
    }
}
