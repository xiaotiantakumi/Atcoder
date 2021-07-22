using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC013
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = r1[0];
            var M = r1[1];
            var L = r1[2];
            var P = r2[0];
            var Q = r2[1];
            var R = r2[2];
            var ret1 = (N / P) * (M / Q) * (L / R);
            var ret2 = (N / Q) * (M / R) * (L / P);
            var ret3 = (N / R) * (M / P) * (L / Q);
            var ret4 = (N / P) * (M / R) * (L / Q);
            var ret5 = (N / Q) * (M / P) * (L / R);
            var ret6 = (N / R) * (M / Q) * (L / P);
            var r1Max = Max(r1[0], r1[1], r1[2]);
            var r2Max = Max(r2[0], r2[1], r2[2]);
            if (r1Max < r2Max)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(Max(ret1, ret2, ret3, ret4, ret5, ret6));
        }
    }
}