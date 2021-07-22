using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC131
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var ABCD = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = ABCD[0];
            var B = ABCD[1];
            var C = ABCD[2];
            var D = ABCD[3];

            var divC = B / C - (A - 1) / C;
            var divD = B / D - (A - 1) / D;
            var l = Lcm(C, D);
            var divCD = B / l - (A - 1) / l;
            var ret = (B - A + 1) - (divC + divD - divCD);
            Console.WriteLine(ret);
        }

        public static long Lcm(long a, long b)
        {
            return a * (b / Gcd(a, b));
        }
        public static long Gcd(long a, long b)
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