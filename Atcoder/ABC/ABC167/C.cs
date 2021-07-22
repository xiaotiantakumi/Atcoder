using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC167
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var NMX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int[]> CAs = new List<int[]>();
            for (int i = 0; i < NMX[0]; i++)
            {
                CAs.Add(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            // {0, 1, ..., n-1} の部分集合の全探索
            int n = NMX[0];
            int ret = int.MaxValue;
            for (int bit = 0; bit < (1 << n); ++bit)
            {
                int[] cal = new int[NMX[1] + 1];
                for (int i = 0; i < n; ++i)
                {
                    if ((bit & (1 << i)) != 0)
                    {
                        for (var j = 0; j < CAs[i].Length; j++)
                        {
                            cal[j] += CAs[i][j];
                        }
                    }
                }

                bool canInclude = cal.Skip(1).All(x => x >= NMX[2]);
                if (canInclude)
                {
                    ret = Math.Min(ret, cal[0]);
                }

            }

            if (int.MaxValue == ret)
            {
                Console.WriteLine(-1);
                return;
            }
            Console.WriteLine(ret);
        }
    }
}