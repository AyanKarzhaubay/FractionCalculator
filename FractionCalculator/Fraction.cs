using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Fraction
    {
        public int a = 0, n, d;
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.n = f1.n * f2.d + f1.d * f2.n;
            f.d = f1.d * f2.d;
            f.Cut();
            return f;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.n = f1.n * f2.d - f1.d * f2.n;
            f.d = f1.d * f2.d;
            f.Cut();
            return f;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.n = f1.n * f2.n;
            f.d = f1.d * f2.d;
            f.Cut();
            return f;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.n = f1.n / f2.n;
            f.d = f1.d / f2.d;
            f.Cut();
            return f;
        }
        public void Cut()
        {
            int gcf = MathHelper.GCF(n, d);
            n /= gcf;
            d /= gcf;
        }
        public void ConvertToImprorerFraction()
        {
            if (a != 0) 
            {
                n += a * d;
                a = 0;
            }
            Cut();
        }
        public void ConvertToMixedFraction()
        {
            int t = n % d;
            a = (n - t) / d;
            n = t;
            Cut();
        }
        public override string ToString()
        {
            return $"{n}/{d}";
        }
    }
}
