using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC176
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var times = Math.Ceiling(NXT[0] / NXT[1]);
            Console.WriteLine(times * NXT[2]);
        }
    }
}