using System;
using System.Linq;

namespace Atcoder.ABC080
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(r[0] * r[1], r[2]));
        }
    }
}