using System;
using System.Linq;

namespace Atcoder.ABC.ABC188
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Y = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                ret += X[i] * Y[i];
            }

            Console.WriteLine(ret == 0 ? "Yes" : "No");
        }
    }
}