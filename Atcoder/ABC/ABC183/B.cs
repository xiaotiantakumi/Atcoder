using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC183
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var inputs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var Sx = inputs[0];
            var Sy = inputs[1];
            var Gx = inputs[2];
            var Gy = -inputs[3];
            var a = (Sy - Gy) / (Sx - Gx);
            var b = Sy - a * Sx;
            Console.WriteLine(-b / a);
        }
    }
}