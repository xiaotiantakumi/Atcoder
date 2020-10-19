using System;
using System.Linq;

namespace Atcoder.ABC.ABC180
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = decimal.Parse(Console.ReadLine());
            var xs = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal ret = 0;
            decimal ret2 = 0;
            decimal ret3 = 0;
            for (int i = 0; i < N; i++)
            {
                ret += Math.Abs(xs[i]);
                ret2 += xs[i] * xs[i];
                ret3 = Math.Max(ret3, Math.Abs(xs[i]));
            }

            Console.WriteLine(ret);
            Console.WriteLine(Math.Sqrt((double)ret2));
            Console.WriteLine(ret3);
        }
    }
}