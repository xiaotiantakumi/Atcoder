using System;
using System.Linq;

namespace Atcoder.ABC.ABC123
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var A = long.Parse(Console.ReadLine());
            var B = long.Parse(Console.ReadLine());
            var C = long.Parse(Console.ReadLine());
            var D = long.Parse(Console.ReadLine());
            var E = long.Parse(Console.ReadLine());
            decimal ret = 4;
            var min = GetMin(A, B, C, D, E);
            ret += Math.Ceiling((decimal)N / (decimal)min);
            Console.WriteLine(ret);
        }

        static long GetMin(params long[] args)
        {
            return args.Min();
        }
    }
}