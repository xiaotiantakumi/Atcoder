using System;

namespace Atcoder.ABC.ABC033
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long sum = 0;
            string ret = string.Empty;
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                var SP = Console.ReadLine().Split();
                var S = SP[0];
                var P = int.Parse(SP[1]);
                sum += P;
                if (P > max)
                {
                    ret = S;
                    max = P;
                }
            }

            var flg = 0.5 < (double)max / (double)sum;
            if (flg)
            {
                Console.WriteLine(ret);
            }
            else
            {
                Console.WriteLine("atcoder");
            }
        }
    }
}