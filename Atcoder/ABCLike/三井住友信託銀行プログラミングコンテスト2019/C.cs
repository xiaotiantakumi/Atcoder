using System;
using CoderCommon;

namespace Atcoder.ABCLike.三井住友信託銀行プログラミングコンテスト2019
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var X = int.Parse(Console.ReadLine());
            int f = X / 100;
            decimal rem = X % 100;
            decimal remC = Math.Ceiling(rem / 5);
            if (f < (int)remC)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}