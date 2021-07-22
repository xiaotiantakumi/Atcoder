using System;
using CoderCommon;

namespace Atcoder.ABC157
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = ReadInt();
            Console.WriteLine(N % 2 == 0 ? N / 2 : N / 2 + 1);
        }
    }
}