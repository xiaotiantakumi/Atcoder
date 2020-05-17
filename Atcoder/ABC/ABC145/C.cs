using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC145
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var townsPos = Enumerable.Repeat(0, N).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToList();
            int[] towns = new int[N];
            for (int i = 0; i < N; i++)
            {
                towns[i] = i;
            }
            var allPermutation = AllPermutation(towns);

            double distance = 0;

            foreach (var p in allPermutation)
            {
                for (int i = 0; i < p.Length - 1; i++)
                {
                    distance += Math.Sqrt(Math.Pow(Math.Abs(townsPos[p[i]][0] - townsPos[p[i + 1]][0]), 2) +
                                          Math.Pow(Math.Abs(townsPos[p[i]][1] - townsPos[p[i + 1]][1]), 2));
                }

            }

            Console.WriteLine(distance / allPermutation.Count());
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