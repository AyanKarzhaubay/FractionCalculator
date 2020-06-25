using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class MathHelper
    {
        public static int GCF(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a % b > 0)
                {
                    var temp = a;
                    a = b;
                    b = temp % b;
                }
                else break;
            }
            return b;
        }
        public static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCF(a, b);
        }
    }
}
