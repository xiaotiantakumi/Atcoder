using System;
using CoderCommon;

namespace Atcoder.ABC074
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            Console.WriteLine(N * N - A);
        }
    }
}