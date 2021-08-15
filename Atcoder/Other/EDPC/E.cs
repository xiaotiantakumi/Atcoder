using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other.EDPC
{
    public class E : CoderBase
    {
        public override void Run()
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NW[0];
            var W = NW[1];
            long ret = 0;
            List<int[]> wvs = new List<int[]>();
            for (int i = 0; i < N; i++)
            {
                var wv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                wvs.Add(wv);
            }

            var maxV = wvs.Sum(x => x[1]);
            long[,] dp = new long[N + 1, maxV + 1];
            for (int j = 1; j <= maxV; j++)
            {
                dp[0, j] = int.MaxValue;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= maxV; j++)
                {
                    dp[i + 1, j] = dp[i, j];
                    if (j - wvs[i][1] >= 0)
                    {
                        dp[i + 1, j] = Math.Min(dp[i, j], dp[i, j - wvs[i][1]] + wvs[i][0]);
                    }
                }
            }

            for (int i = 0; i <= maxV; i++)
            {
                if (dp[N, i] <= W) ret = Math.Max(ret, i);
            }

            Console.WriteLine(ret);
        }
    }
}