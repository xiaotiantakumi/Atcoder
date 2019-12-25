using System;
using System.Linq;

namespace Atcoder.ABC110
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var X = r[2];
            var Y = r[3];
            var xs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var maxX = xs.Max();
            var minY = ys.Min();
            for (int i = X + 1; i <= Y; i++)
            {
                if (maxX < i && minY >= i)
                {
                    Console.WriteLine("No War");
                    return;
                }
            }
            Console.WriteLine("War");
        }
    }
}