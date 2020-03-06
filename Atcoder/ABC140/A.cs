using System;

namespace Atcoder.ABC140
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N * N * N);
        }
    }
}