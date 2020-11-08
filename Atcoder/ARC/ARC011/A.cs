using System;
using System.Linq;

namespace Atcoder.ARC.ARC011
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var mnN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var m = mnN[0];
            var n = mnN[1];
            var N = mnN[2];
            long ret = N;
            long remain = 0;
            while (N >= m)
            {
                ret += N / m * n;
                N = N / m * n + N % m;
            }

            Console.WriteLine(ret);
        }
    }
}