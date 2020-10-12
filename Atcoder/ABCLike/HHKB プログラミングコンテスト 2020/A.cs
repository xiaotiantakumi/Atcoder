using System;

namespace Atcoder.ABCLike.HHKB_プログラミングコンテスト_2020
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var Y = Console.ReadLine();
            var S = Console.ReadLine();
            if (Y == "Y")
            {
                Console.WriteLine(S.ToUpper());
            }
            else
            {
                Console.WriteLine(S);
            }
        }
    }
}