using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit1_SimpleCalculator
{
    public class SimpleCalculator
    {
        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            if (value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value)); // for demo
            }
            return value / by;
        }

        public int MultiplyInts(int a, int b)
        {
            return a * b;
        }
    }
}
