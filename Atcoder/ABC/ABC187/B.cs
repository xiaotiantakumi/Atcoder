using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC187
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<decimal[]> items = new List<decimal[]>();
            for (int i = 0; i < N; i++)
            {
                var item = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
                items.Add(item);
            }

            int ret = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (Math.Abs(items[i][1] - items[j][1]) <= Math.Abs(items[i][0] - items[j][0]))
                    {
                        ret++;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}