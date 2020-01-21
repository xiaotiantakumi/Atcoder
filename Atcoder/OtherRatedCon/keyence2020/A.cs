using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.OtherRatedCon.keyence2020
{
    public class A : IAtcoder
    {
        public void Run()
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