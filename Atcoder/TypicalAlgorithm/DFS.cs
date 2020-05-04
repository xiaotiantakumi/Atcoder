using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.TypicalAlgorithm
{
    //ABC130のDより
    public class DFS : AtcoderBase
    {
        private int[] dx = new int[4]{ 1, 0, -1, 0 };
        private int[] dy = new int[4] { 0, 1, 0, -1 };

        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NM[0];
            var M = NM[1];

            // 入力からグラフデータ受け取り
            var graph = GetGraph(M);

            // 深さ優先探索
            seen = new bool[N];
            Dfs(graph, 0);

            // ここで出力とか
        }

        private static Dictionary<int, List<int>> GetGraph(int edgeCount)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            // 読込部分
            for (int i = 0; i < edgeCount; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!graph.ContainsKey(ab[0]))
                {
                    graph.Add(ab[0], new List<int>() {ab[1]});
                }
                else
                {
                    graph[ab[0]].Add(ab[1]);
                }

                if (!graph.ContainsKey(ab[1]))
                {
                    graph.Add(ab[1], new List<int>() {ab[0]});
                }
                else
                {
                    graph[ab[1]].Add(ab[0]);
                }
            }

            return graph;
        }

        private static bool[] seen;
        static void Dfs(Dictionary<int, List<int>> graph, int v)
        {
            seen[v] = true; // v を訪問済にする

            // v から行ける各頂点 next_v について
            foreach (var nextV in graph[v])
            {
                if (seen[nextV]) continue; // next_v が探索済だったらスルー
                Dfs(graph, nextV); // 再帰的に探索
            }
        }
    }
}