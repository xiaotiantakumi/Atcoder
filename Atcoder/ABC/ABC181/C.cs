using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC181
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<double[]> items = new List<double[]>();
            for (int i = 0; i < N; i++)
            {
                var xy = Console.ReadLine().Split().Select(double.Parse).ToArray();
                items.Add(xy);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        var y1 = items[i][1];
                        var y2 = items[j][1];
                        var y3 = items[k][1];
                        var x1 = items[i][0];
                        var x2 = items[j][0];
                        var x3 = items[k][0];
                        if ((y3 - y1) * (x2 - x1) == (y2 - y1) * (x3 - x1))
                        {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}