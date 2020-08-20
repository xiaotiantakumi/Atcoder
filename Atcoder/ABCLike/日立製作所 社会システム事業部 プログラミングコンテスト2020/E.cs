using System;

namespace Atcoder.ABCLike.日立製作所_社会システム事業部_プログラミングコンテスト2020
{
    public class E : AtcoderBase
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