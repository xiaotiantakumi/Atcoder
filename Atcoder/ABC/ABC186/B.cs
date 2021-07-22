using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC186
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = r[0];
            var W = r[1];
            int min = int.MaxValue;
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < H; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                min = Math.Min(min, Min(row));
                list.Add(row);
            }

            int ret = 0;
            foreach (var row in list)
            {
                foreach (var item in row)
                {
                    if (item > min)
                    {
                        ret += item - min;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}