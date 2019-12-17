using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC088
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var r1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int[]> grid = new List<int[]>() { r1, r2, r3 };

            var a1 = r1.Min();
            var a2 = r2.Min();
            var a3 = r3.Min();
            int[] a = new int[3] { a1, a2, a3 };
            int[] b = new int[3];
            for (int i = 0; i < 3; i++)
            {
                b[i] = Math.Min(r1[i], Math.Min(r2[i], r3[i]));
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i][j] <= a[i] + b[j])
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            Console.WriteLine("Yes");
        }
    }
}