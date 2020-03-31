using System;

namespace Atcoder.ABC044
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var K = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(K, N) * X + Math.Max(0, (N - K) * Y));
        }
    }
}