using System;
using System.Collections.Generic;
using System.Linq;

namespace AOJ.ALDS1._11
{
    class A
    {
        public static void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < N; i++)
            {
                var ukv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var u = ukv[0];
                var k = ukv[1];
                graph[u] = new List<int>();
                for (int j = 0; j < k; j++)
                {
                    graph[u].Add(ukv[2 + j]);
                }
            }

            foreach (var v in graph)
            {
                int[] rowRet = new int[N];
                foreach (var item in v.Value)
                {
                    rowRet[item - 1] = 1;
                }

                Console.WriteLine(string.Join(" ", rowRet));
            }
        }

    }
}
