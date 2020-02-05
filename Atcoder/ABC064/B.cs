using System;
using System.Linq;

namespace Atcoder.ABC064
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var points = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(points.Max() - points.Min());
        }
    }
}