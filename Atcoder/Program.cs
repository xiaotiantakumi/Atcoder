using System;
using System.Collections.Generic;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using Atcoder.Algorithm;
using CoderCommon;
using CoderCommon.Library;
using Microsoft.VisualBasic.CompilerServices;
using Console = System.Console;

namespace Atcoder
{
    partial class Program
    {
        private const long COMDIV = 1000000007;

        static void Main()
        {
            SourceExpander.Expander.Expand(ignoreAnyError: false);
            int[] a = new[] { 7,5,3,1,8};
            var N = a.Length - 1;
            int A = 12;
            int[,] dp = new int[N+1, 1000100];
            dp[0, 0] = 1;
            var MOD = 1000000009;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= A; j++)
                {
                    dp[i + 1,j] += dp[i,j] %= MOD;
                    if (j >= a[i]) dp[i + 1, j] += dp[i, j - a[i]] %= MOD;
                }
            }
            Console.WriteLine(dp[N,A]);
        }
        
    }
    
}