using System;
using System.Linq;

namespace Atcoder.ABC094
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = f[0];
            var M = f[1];
            var X = f[2];
            var seconds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int left = 0;
            int right = 0;
            for (int i = 0; i < N; i++)
            {
                if (!seconds.Contains(i))
                {
                    continue;
                }
                if (i <= X)
                {
                    left++;
                }
                else
                {
                    right++;
                }
            }

            Console.WriteLine(left < right ? left : right);
        }
    }
}