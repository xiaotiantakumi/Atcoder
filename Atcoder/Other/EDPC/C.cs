using System;
using System.Linq;

namespace Atcoder.Other.EDPC
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var dp = new int[N, 3];
            for (int i = 0; i < N; i++)
            {
                var abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
                dp[i, 0] = abc[0];
                dp[i, 1] = abc[1];
                dp[i, 2] = abc[2];
                if (i != 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var comp = dp[i, j];
                        for (int k = 0; k < 3; k++)
                        {
                            if (j == k) continue;
                            comp = Math.Max(dp[i, j] + dp[i - 1, k], comp);
                        }
                        dp[i, j] = comp;
                    }
                }
            }

            int ret = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                ret = Math.Max(ret, dp[N - 1, i]);
            }

            Console.WriteLine(ret);
        }
    }
}