using System;
using CoderCommon;

namespace Atcoder.ABCLike.パナソニックプログラミングコンテスト2020
{
    public class E : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            for (int i = 1; i <= N; i++)
            {
                var ret = string.Empty;
                if (i % 2 == 0)
                {
                    ret += "a";
                }
                if (i % 3 == 0)
                {
                    ret += "b";
                }
                if (i % 4 == 0)
                {
                    ret += "c";
                }
                if (i % 5 == 0)
                {
                    ret += "d";
                }
                if (i % 6 == 0)
                {
                    ret += "e";
                }
                if (string.IsNullOrEmpty(ret))
                {
                    ret += i.ToString();
                }
                Console.WriteLine(ret);
            }
        }
    }
}