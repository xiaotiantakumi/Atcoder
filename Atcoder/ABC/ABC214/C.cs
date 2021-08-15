using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC214
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var Si = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Ti = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] dp = new int[N];
            for (int i = 0; i < 2 * N; i++)
            {
                dp[(i + 1) % N] = Math.Min(dp[i % N] + Si[i % N], Ti[(i + 1) % N]);
            }

            Console.WriteLine(string.Join(Environment.NewLine, dp));
        }
    }
}