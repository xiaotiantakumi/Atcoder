using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC037
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NQ[0];
            var Q = NQ[1];
            int[] ret = new int[N];
            for (int i = 0; i < Q; i++)
            {
                var LRT = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = LRT[0] - 1; j < LRT[1]; j++)
                {
                    ret[j] = LRT[2];
                }
            }

            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }
        }
    }
}