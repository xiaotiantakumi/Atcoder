using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABCLike.MSOLUTIONS_プロコンオープン_2020
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NK[0];
            var K = NK[1];
            var As = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (int i = K; i < N; i++)
            {

                //var cur = As[i - K] + As[i - 1];
                //var next = As[i - K + 1] + As[i];
                var isLarge = As[i] - As[i - K] > 0;
                Console.WriteLine(isLarge ? "Yes" : "No");
            }
        }
    }
}