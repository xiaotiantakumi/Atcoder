using System;
using System.Linq;

namespace Atcoder.ABC140
{
    public class B : IAtcoder
    {
        public void Run()
        {
            // 問題文だけでは内容理解できなかった。
            // 解説読んでやっと何をさせたいのか理解できた。
            var N = int.Parse(Console.ReadLine());
            var Ai = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ret = Console.ReadLine().Split(' ').Select(int.Parse).Sum();
            var Ci = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N - 1; i++)
            {
                if (Ai[i + 1] - Ai[i] == 1)
                {
                    ret += Ci[Ai[i] - 1];
                }
            }
            Console.Write(ret);
        }
    }
}