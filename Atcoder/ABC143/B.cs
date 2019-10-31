using System;
using System.Linq;

namespace Atcoder.ABC143
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var secound = Console.ReadLine().Split((' ')).Select(int.Parse).ToArray();

            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (i + 1 != secound[i])
                {
                    counter++;
                }
            }

            if (counter > 2)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}