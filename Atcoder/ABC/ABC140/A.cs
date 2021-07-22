using System;
using CoderCommon;

namespace Atcoder.ABC140
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N * N * N);
        }
    }
}