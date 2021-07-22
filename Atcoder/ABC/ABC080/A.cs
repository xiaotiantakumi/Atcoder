using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC080
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(r[0] * r[1], r[2]));
        }
    }
}