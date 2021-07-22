using System;
using System.Linq;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.Learning
{
    public class ATC001 : CoderBase
    {
        private static int H;
        private static int W;
        private static string[] field;
        public override void Run()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            H = HW[0];
            W = HW[1];

            // 入力からグラフデータ受け取り
            field = new string[H];
            for (int i = 0; i < H; i++)
            {
                field[i] = Console.ReadLine();
                seen.Add(new bool[W]);
            }

            // s と g のマスを特定する
            int sh = 0;
            int sw = 0;
            int gh = 0;
            int gw = 0;
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (field[h][w] == 's') sh = h; sw = w;
                    if (field[h][w] == 'g') gh = h; gw = w;
                }
            }

            // 深さ優先探索
            Dfs(sh, sw);

            if (seen[gh][gw])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static int[] dx = new int[4] { 1, 0, -1, 0 };
        private static int[] dy = new int[4] { 0, 1, 0, -1 };

        private static List<bool[]> seen = new List<bool[]>();
        static void Dfs(int h, int w)
        {
            seen[h][w] = true; // 訪問済にする

            // 四方向を探索
            for (int dir = 0; dir < 4; ++dir)
            {
                int nh = h + dx[dir];
                int nw = w + dy[dir];

                // 場外アウトしたり、移動先が壁の場合はスルー
                if (nh < 0 || nh >= H || nw < 0 || nw >= W) continue;
                if (field[nh][nw] == '#') continue;

                // 移動先が探索済みの場合
                if (seen[nh][nw]) continue;

                // 再帰的に探索
                Dfs(nh, nw);
            }
        }

        //public override void Run()
        //{
        //    var hw = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //    int h = hw[0];
        //    int w = hw[1];
        //    var s = string.Join("", Enumerable.Repeat(0, h).Select(_ => Console.ReadLine()));
        //    List<int>[] graph = Enumerable.Repeat(0, h * w).Select(_ => new List<int>()).ToArray();
        //    for (int i = 0; i < h - 1; i++)
        //    for (int j = 0; j < w; j++)
        //    { var id = i * w + j; graph[id].Add(id + w); graph[id + w].Add(id); }
        //    for (int i = 0; i < h; i++)
        //    for (int j = 0; j < w - 1; j++)
        //    { var id = i * w + j; graph[id].Add(id + 1); graph[id + 1].Add(id); }
        //    var startInd = s.IndexOf('s');
        //    var goalInd = s.IndexOf('g');
        //    bool[] canAchieve = new bool[h * w];
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(startInd);
        //    canAchieve[startInd] = true;
        //    while (stack.Count > 0)
        //    {
        //        var elem = stack.Pop();
        //        foreach (var item in graph[elem])
        //        {
        //            if (s[item] == '#' || canAchieve[item]) continue;
        //            canAchieve[item] = true;
        //            stack.Push(item);
        //        }
        //    }
        //    Console.WriteLine(canAchieve[goalInd] ? "Yes" : "No");
        //}
    }
}