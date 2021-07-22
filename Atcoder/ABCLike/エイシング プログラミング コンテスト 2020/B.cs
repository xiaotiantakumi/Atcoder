using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.エイシング_プログラミング_コンテスト_2020
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                if ((i + 1) % 2 == 0) continue;
                if (As[i] % 2 != 0) ret++;
            }

            Console.WriteLine(ret);
        }
    }
}