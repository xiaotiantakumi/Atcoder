using System;
using System.Linq;

namespace Atcoder.ABC140
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var Ai = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ret = Console.ReadLine().Split(' ').Select(int.Parse).Sum();
            var Ci = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N - 1; i++)
            {
                if (Ai[i + 1] - Ai[i] == 1)
                {
                    ret += Ci[Ai[i] - 1];
                }
            }
            Console.Write(ret);
        }
    }
}