using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.Other
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var xy2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = Math.Abs(xy[0] - xy2[0]) + Math.Abs(xy[1] - xy2[1]) + 1;
            Console.WriteLine(ret);
        }
    }
}