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

            if (X + 1 > Xs.Max())
            {

            }
            int from = Math.Min(X + 1, Xs.Max());
            int end = Math.Max(Y, Xs.Min());
            // はじめi = Xとしていがが、これだと条件X<Z≤Yを満たさず、X≤Z≤Yとなってしまう。
            for (int i = X + 1; i < Y; i++)
            {
                // x1,x2,...,xN<Z
                // y1,y2,...,yM≥Zの条件
                if (Xs.Max() < i && Ys.Min() <= i)
                {
                    Z = i;
                    break;
                }
            }

            if (Z == int.MinValue)
            {
                Console.WriteLine("War");
                return;
            }

            Console.WriteLine("No War");
        }
    }
}