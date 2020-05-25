using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atcoder.Algorithm
{
    class BFS
    {
        public void Execute()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NM[0];
            var M = NM[1];

            // Graphを初期化
            List<List<int>> Graph = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                Graph.Add(new List<int>());
            }

            // 入力で受け取った値をGraphに反映
            for (int i = 0; i < M; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var a = ab[0];
                var b = ab[1];
                Graph[a].Add(b);
                Graph[b].Add(a);
            }

            // 距離情報
            int[] dist = new int[N];
            for (var i = 0; i < dist.Length; i++)
            {
                dist[i] = -1;
            }

            // 訪問予定を格納するキュー
            Queue<int> que = new Queue<int>();

            // 探索前初期値セット
            dist[0] = 0;
            que.Enqueue(0);

            while (que.Any())
            {
                // 訪問対象をキューから取得
                int v = que.Dequeue();

                // v から辿れる頂点をすべて調べる
                foreach (var point in Graph[v])
                {
                    // 未訪問でない場合はcontinue
                    if (dist[point] != -1) continue;

                    // 未訪問の場合
                    // 今いる地点vから+1ステップで到達できる距離
                    dist[point] = dist[v] + 1;

                    // 訪問予定に追加
                    que.Enqueue(point);
                }
            }

            for (int v = 0; v < N; v++)
            {
                Console.WriteLine($"{v} : {dist[v]}");
            }
        }
    }

}
