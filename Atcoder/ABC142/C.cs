using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC142
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                dic.Add(r[i], i + 1);
            }

            Console.WriteLine(string.Join(" ", dic.Select(x => x.Value)));
        }
    }
}