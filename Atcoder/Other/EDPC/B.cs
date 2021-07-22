using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other.EDPC
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var hs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NK[0];
            var K = NK[1];

            int[] dp = new int[N + 1];
            dp[0] = 0;
            for (int i = 1; i < N; i++)
            {
                dp[i] = Math.Abs(hs[i] - hs[i - 1]) + dp[i - 1];

                for (int j = 1; j <= K && i - j >= 0; j++)
                {
                    dp[i] = Math.Min(Math.Abs(hs[i] - hs[i - j]) + dp[i - j],
                        dp[i]);
                }
            }

            Console.WriteLine(dp[N - 1]);
        }
    }
}