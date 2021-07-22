using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.エイシング_プログラミング_コンテスト_2019
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Ps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> ret = new List<int>() { 0, 0, 0 };

            for (int i = 0; i < N; i++)
            {
                if (Ps[i] <= AB[0])
                {
                    ret[0]++;
                }
                else if (Ps[i] > AB[0] && Ps[i] <= AB[1])
                {
                    ret[1]++;
                }
                else if (Ps[i] > AB[1])
                {
                    ret[2]++;
                }
            }

            Console.WriteLine(ret.Min());
        }
    }
}