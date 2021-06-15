using System;
using System.Linq;

namespace Atcoder.ABC.ABC200
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var N = NK[0];
            var K = NK[1];
            for (int i = 0; i < K; i++)
            {
                if (N % 200 == 0)
                {
                    N /= 200;
                }
                else
                {
                    N = decimal.Parse(N.ToString() + "200");
                }
            }

            Console.WriteLine(N);
        }
    }
}