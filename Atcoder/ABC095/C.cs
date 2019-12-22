using System;
using System.Linq;

namespace Atcoder.ABC095
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = r[0];
            var B = r[1];
            var C = r[2];
            var X = r[3];
            var Y = r[4];
            int p = 0;

            if (A + B <= 2 * C)
            {
                Console.WriteLine(X * A + Y * B);
            }
            else if (A >= 2 * C &&
                     B >= 2 * C)
            {
                Console.WriteLine(Math.Max(X, Y) * C * 2);
            }
            else if (A >= 2 * C &&
                     B <= 2 * C)
            {
                p += X * C * 2;
                if (B - A > 0)
                {
                    p += (B - A) * Y;
                }
                Console.WriteLine(p);
            }
            else if (A <= 2 * C &&
                     B >= 2 * C)
            {
                p += Y * C * 2;
                if (A - B > 0)
                {
                    p += (A - B) * X;
                }
                Console.WriteLine(p);
            }
            else
            {
                if (X - Y < 0)
                {
                    p += (Y - X) * B;
                    p += X * 2 * C;
                }
                else
                {
                    p += (X - Y) * A;
                    p += Y * 2 * C;
                }
                Console.WriteLine(p);
            }
        }
    }
}