using System;
using System.Linq;

namespace Atcoder.ABC110
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            var N = input[0];
            var M = input[1];
            var X = input[2];
            var Y = input[3];
            var Xs = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            var Ys = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();

            int Z = int.MinValue;
            // はじめi = Xとしていがが、これだと条件X<Z≤Yを満たさず、X≤Z≤Yとなってしまう。
            for (int i = X + 1; i < Y; i++)
            {
                // ZはYsの一部である必要がないのでWAとなっているはず。
                if (Ys.Contains(i))
                {
                    Z = i;
                }
            }

            if (Z == int.MinValue)
            {
                Console.WriteLine("War");
                return;
            }

            if (Xs.Max() >= Z || Ys.Min() < Z)
            {
                Console.WriteLine("War");
                return;
            }

            Console.WriteLine("No War");
        }
    }
}