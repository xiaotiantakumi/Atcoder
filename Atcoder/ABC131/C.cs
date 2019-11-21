using System;
using System.Linq;

namespace Atcoder.ABC131
{
    public class C : IAtcoder
    {
        public void Run()
        {
            // 最初に思いついたのはこれ。
            // でもサンプルの３つめですでに結果が返ってこない。。。
            // 工夫して実行速度を速める必要がある。
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var C = input[2];
            var D = input[3];
            int ret = 0;
            for (long i = A; i <= B; i++)
            {
                if (i % C != 0 && i % D != 0)
                {
                    ret++;
                }
            }
            Console.Write(ret);
        }
    }
}