using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC183
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var costs = new List<List<int>>();
            List<int> items = new List<int>();
            for (int i = 0; i < NK[0]; i++)
            {
                if (i != NK[0])
                {
                    var inp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    costs.Add(inp.ToList());
                }

                if (i > 0)
                {
                    items.Add(i);
                }
            }

            int ret = 0;
            var tmp = AllPermutation(items.ToArray());
            foreach (var ptn in tmp)
            {
                var tmpCost = 0;
                for (var i = 0; i <= ptn.Length; i++)
                {
                    if (i == ptn.Length)
                    {
                        tmpCost += costs[ptn[i - 1]][0];
                    }
                    else if (i == 0)
                    {
                        tmpCost += costs[0][ptn[i]];
                    }
                    else
                    {
                        tmpCost += costs[ptn[i - 1]][ptn[i]];
                    }
                }

                if (tmpCost == NK[1])
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
        public static List<T[]> AllPermutation<T>(params T[] array) where T : IComparable
        {
            var a = new List<T>(array).ToArray();
            var res = new List<T[]>();
            res.Add(new List<T>(a).ToArray());
            var n = a.Length;
            var next = true;
            while (next)
            {
                next = false;

                // 1
                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) break;
                }
                // 2
                if (i < 0) break;

                // 3
                var j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    // 4
                    var tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    Array.Reverse(a, i + 1, n - i - 1);
                    res.Add(new List<T>(a).ToArray());
                    next = true;
                }
            }
            return res;
        }
    }
}