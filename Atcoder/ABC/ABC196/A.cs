using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC196
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var x = Math.Max(ab[0], ab[1]);
            var y = Math.Min(cd[0], cd[1]);
            Console.WriteLine(x - y);
        }
    }
}