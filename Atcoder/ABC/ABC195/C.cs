using System;
using System.Numerics;

namespace Atcoder.ABC.ABC195
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var range1 = (long)Math.Pow(10, 3) - 1;
            var range2 = (long)Math.Pow(10, 6) - 1;
            var range3 = (long)Math.Pow(10, 9) - 1;
            var range4 = (long)Math.Pow(10, 12) - 1;
            var range5 = (long)Math.Pow(10, 15) - 1;
            BigInteger ret = 0;
            ret += N - range1 >= 0 ? N - range1 : 0;
            ret += N - range2 >= 0 ? N - range2 : 0;
            ret += N - range3 >= 0 ? N - range3 : 0;
            ret += N - range4 >= 0 ? N - range4 : 0;
            ret += N - range5 >= 0 ? N - range5 : 0;
            Console.WriteLine(ret);
        }
    }
}