using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Atcoder
{

    class Program
    {
        private const long COMDIV = 1000000007;

        static void Main(string[] args)
        {
            var NW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NW[0];
            var W = NW[1];
            int[,] dp = new int[N+1,W+1];
            int[] ws = new int[N+1];
            int[] vs = new int[N+1];

            for (int i = 1; i <= N; i++)
            {
                var wv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ws[i] = wv[0];
                vs[i] = wv[1];
            }
            for (int i = 1; i <= N; i++)
            {
                for (int v = 0; v <= vs.Sum(); v++)
                {
                    dp[i, v] = dp[i - 1, v];
                    if (v - vs[i] >= 0)
                    {
                        dp[i,v] = Math.Max(dp[i,v],dp[i - 1,v - ws[i]] + vs[i]);
                    }
                }

            }
            
            Console.WriteLine(dp[N,W]);
        }
    }
}