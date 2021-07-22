using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.HHKB_プログラミングコンテスト_2020
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var Ps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int current = 0;
            HashSet<int> vals = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                vals.Add(Ps[i]);
                while (true)
                {
                    if (!vals.Contains(current))
                    {
                        Console.WriteLine(current);
                        break;
                    }
                    else
                    {
                        current++;
                    }
                }
            }
        }
    }
}