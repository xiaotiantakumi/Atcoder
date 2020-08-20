using System;

namespace Atcoder.ABCLike.keyence2020
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var H = int.Parse(Console.ReadLine());
            var W = int.Parse(Console.ReadLine());
            var N = int.Parse(Console.ReadLine());
            var max = Math.Max(H, W);
            var ret = (N + (max - 1)) / max;
            Console.WriteLine(ret);
        }
    }
}