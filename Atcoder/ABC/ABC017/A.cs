using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC017
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = r1[0] * r1[1] / 10 + r2[0] * r2[1] / 10 + r3[0] * r3[1] / 10;
            Console.WriteLine(sum);
        }
    }
}