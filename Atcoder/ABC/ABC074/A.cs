using System;

namespace Atcoder.ABC074
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            Console.WriteLine(N * N - A);
        }
    }
}