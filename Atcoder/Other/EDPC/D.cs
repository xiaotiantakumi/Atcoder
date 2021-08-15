using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other.EDPC
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NW[0];
            var W = NW[1];
            long[,] dp = new long[N + 1, W + 1];
            for (int i = 0; i < N; i++)
            {
                var wv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j <= W; j++)
                {
                    dp[i + 1, j] = dp[i, j];
                    if (j - wv[0] >= 0){
                        dp[i + 1, j] = Math.Max(dp[i, j], dp[i, j - wv[0]] + wv[1]);
                    }
                }
            }

            long ret = 0;
            for (int i = 0; i <= W; i++)
            {
                ret = Math.Max(ret, dp[N, i]);
            }

            Console.WriteLine(ret);
        }
    }
}