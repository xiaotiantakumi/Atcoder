using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2017
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = 0;
            SortedDictionary<int, int> items = new SortedDictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                items.Add(tmp[0], tmp[1]);
            }

            Console.WriteLine(items.Last().Key + items.Last().Value);
        }
    }
}