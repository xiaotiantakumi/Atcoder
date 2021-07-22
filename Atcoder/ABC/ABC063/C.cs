using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC063
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            List<int> points = new List<int>();
            List<int> minus = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int tmp = ReadInt();
                points.Add(tmp);
                if (tmp % 10 != 0)
                {
                    minus.Add(tmp);
                }
            }

            minus = minus.OrderBy(x => x).ToList();
            var pointSum = points.Sum();

            if (pointSum % 10 != 0)
            {
                Console.WriteLine(pointSum);
                return;
            }
            if (minus.Any())
            {
                Console.WriteLine(pointSum - minus[0]);
                return;
            }

            Console.WriteLine(0);
        }
    }
}