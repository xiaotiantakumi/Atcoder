using System;
using CoderCommon;

namespace Atcoder.ABCLike.エイシング_プログラミング_コンテスト_2019
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var H = int.Parse(Console.ReadLine());
            var W = int.Parse(Console.ReadLine());
            Console.WriteLine((N - W + 1) * (N - H + 1));
        }
    }
}