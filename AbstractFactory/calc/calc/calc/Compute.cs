using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    abstract class Compute
    {
        private double num1;
        private double num2;
        private double result;
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public abstract double GetResult();
    }
}
