using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC095
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = r[0];
            var B = r[1];
            var C = r[2];
            var X = r[3];
            var Y = r[4];
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            p1 = Math.Max(X, Y) * 2 * C;
            p2 = A * X + B * Y;
            var tmp = X < Y ? B : A;
            p3 = 2 * C * Math.Min(X, Y) + Math.Abs(X - Y) * tmp;
            var ret = Math.Min(Math.Min(p1, p2), p3);
            Console.WriteLine(ret);
        }
    }
}