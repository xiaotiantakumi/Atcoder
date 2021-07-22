using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC194
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int[]> ABs = new List<int[]>();
            for (int i = 0; i < N; i++)
            {
                var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ABs.Add(AB);
            }
            var minPerOne = ABs.Min(x => x[0] + x[1]);
            var As = ABs.OrderBy(x => x[0]).Take(2).ToList();
            var Bs = ABs.OrderBy(x => x[1]).Take(2).ToList();
            int minAB = int.MaxValue;
            foreach (var A in As)
            {
                foreach (var B in Bs)
                {
                    if (A == B)
                    {
                        continue;
                    }

                    minAB = Math.Min(minAB, Math.Max(A[0], B[1]));
                }
            }
            Console.WriteLine(Math.Min(minPerOne, minAB));
        }
    }
}