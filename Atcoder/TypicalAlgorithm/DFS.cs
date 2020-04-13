using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.TypicalAlgorithm
{
    //ABC130のDより
    public class DFS : AtcoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NM[0];
            var M = NM[1];

            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            // 読込部分
            for (int i = 0; i < M; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!graph.ContainsKey(ab[0]))
                {
                    graph.Add(ab[0], new List<int>() { ab[1] });
                }
                else
                {
                    graph[ab[0]].Add(ab[1]);
                }
                if (!graph.ContainsKey(ab[1]))
                {
                    graph.Add(ab[1], new List<int>() { ab[0] });
                }
                else
                {
                    graph[ab[1]].Add(ab[0]);
                }
            }

            // 深さ優先探索
            seen = new bool[N];
            Dfs(graph, 0);
        }

        private static bool[] seen;
        static void Dfs(Dictionary<int, List<int>> graph, int v)
        {
            seen[v] = true; // v を訪問済にする

            // v から行ける各頂点 next_v について
            foreach (var next_v in graph[v])
            {
                if (seen[next_v]) continue; // next_v が探索済だったらスルー
                Dfs(graph, next_v); // 再帰的に探索
            }
        }
    }
}