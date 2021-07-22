using System;
using CoderCommon;

namespace Atcoder.ABCLike.パナソニックプログラミングコンテスト2020
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var abc = ReadIntArray();
            var ret = Math.Sqrt(abc[0]) + Math.Sqrt(abc[1]) < Math.Sqrt(abc[2]);
            if (ret)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}