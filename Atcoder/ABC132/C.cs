using System;
using System.Linq;

namespace Atcoder.ABC132
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var startVal = r[N / 2 - 1];
            var endVal = r[N / 2];
            Console.WriteLine(endVal - startVal);
        }
    }
}