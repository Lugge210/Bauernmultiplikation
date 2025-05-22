using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bauernmultiplikation
{
    internal class Multiplikator
    {
        public static int Mul(int x, int y)
        {
            if (x == 0 || y == 0) return 0;

            int ergebnis = 0;
            int a = Math.Abs(x);
            int b = Math.Abs(y);

            while (a > 0)
            {
                if ((a & 1) == 1)
                {
                    ergebnis += b;
                }
                a >>= 1;
                b <<= 1;
            }

            return (x < 0 ^ y < 0) ? -ergebnis : ergebnis;
        }
    }
}
