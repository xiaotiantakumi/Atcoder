using System;

namespace Atcoder.ABC.ABC162
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    for (int k = 1; k <= K; k++)
                    {
                        ret += Gcd(Gcd(i, j), k);
                    }
                }
            }

            Console.WriteLine(ret);
        }
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