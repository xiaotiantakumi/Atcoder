using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Util
    {
        public static int Gcd(int a, int b)
        {
            if (a < b)
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
