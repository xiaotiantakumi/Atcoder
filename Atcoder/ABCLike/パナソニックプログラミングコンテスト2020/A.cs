using System;
using System.Collections.Generic;

namespace Atcoder.ABCLike.パナソニックプログラミングコンテスト2020
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var list = new List<int>() { 1, 1, 1, 2, 1, 2, 1, 5, 2, 2, 1, 5, 1, 2, 1, 14, 1, 5, 1, 5, 2, 2, 1, 15, 2, 2, 5, 4, 1, 4, 1, 51 };
            var K = ReadInt();
            Console.WriteLine(list[K - 1]);
        }
    }
}