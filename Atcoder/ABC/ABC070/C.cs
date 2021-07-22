using System;
using CoderCommon;

namespace Atcoder.ABC070
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long ret = 0;
            for (int i = 0; i < N; i++)
            {
                var input = long.Parse(Console.ReadLine());
                if (i == 0)
                {
                    ret = input;
                    continue;
                }

                ret = Lcm(ret, input);
            }
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