using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC064
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var points = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(points.Max() - points.Min());
        }
    }
}