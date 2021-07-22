using System;
using System.Linq;

namespace Atcoder.Other.EDPC
{
    public class D : AtcoderBase
    {
        public override void Run()
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NW[0];
            var W = NW[1];
            int[,] dp = new int[110, 1100000];
            int[] ws = new int[110];
            int[] vs = new int[110];
            for (int i = 1; i <= N; i++)
            {
                var wv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ws[i] = wv[0];
                vs[i] = wv[1];
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j - ws[i] >= 0)
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - ws[i]] + vs[i]);
                }
            }

            Console.WriteLine(dp[N, W]);
        }
    }
}