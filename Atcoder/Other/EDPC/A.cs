using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other.EDPC
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var hs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] dp = new int[N + 1];
            dp[0] = 0;
            for (int i = 1; i < N; i++)
            {
                if (i == 1)
                {
                    dp[i] = Math.Abs(hs[i] - hs[i - 1]) + dp[i - 1];
                }
                else
                {
                    dp[i] = Math.Min(Math.Abs(hs[i] - hs[i - 1]) + dp[i - 1],
                        Math.Abs(Math.Abs(hs[i] - hs[i - 2])) + dp[i - 2]);
                }
            }

            Console.WriteLine(dp[N - 1]);
        }
    }
}