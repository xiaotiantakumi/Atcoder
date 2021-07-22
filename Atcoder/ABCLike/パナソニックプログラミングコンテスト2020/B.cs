using System;
using CoderCommon;

namespace Atcoder.ABCLike.パナソニックプログラミングコンテスト2020
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var HW = ReadLongArray();
            var mul = HW[0] * HW[1];
            if (HW[0] == 1 || HW[1] == 1)
            {
                Console.WriteLine(1);
                return;
            }
            if (mul % 2 == 0)
            {
                Console.WriteLine(mul / 2);
            }
            else
            {
                Console.WriteLine((mul + 1) / 2);
            }
        }
    }
}