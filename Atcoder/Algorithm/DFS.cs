using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atcoder.Algorithm
{
    class DFS
    {
        public List<bool> seen = new List<bool>();
        public void dfs(List<List<int>> graph, int v)
        {
            seen[v] = true;
            foreach (var nextV in graph[v])
            {
                if (seen[nextV])
                {
                    continue;
                }
                dfs(graph, nextV);
            }
        }

        public void Execute()
        {
            var N = 15;
            var M = 14;
            var dfs = new Algorithm.DFS();
            List<List<int>> graph = new List<List<int>>();
            int[][] graph2 = new int[][] { };
            for (int i = 0; i < N; i++)
            {
                graph.Add(new List<int>());
                dfs.seen.Add(false);
            }
            for (int i = 0; i < M; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var a = input[0];
                var b = input[1];
                graph[a].Add(b);
                graph[b].Add(a);
            }
            dfs.dfs(graph, 0);
        }
    }
//    public class DFS
//    {
//        public static void Search(Node root)
//        {
//            if (root == null)
//            {
//                return;
//            }
//            Visit(root);
//            root.Visited = true;
//            if (root.Children != null)
//            {
//                foreach (var node in root.Children)
//                {
//                    if (!node.Visited)
//                    {
//                        Search(node);
//                    }
//                }
//            }
//        }
//
//        private static void Visit(Node root)
//        {
//            // nop
//        }
//    }
//
//
//    public class Node
//    {
//        public bool Visited { get; set; }
//
//        public Node[] Children { get; set; }
//    }

}
