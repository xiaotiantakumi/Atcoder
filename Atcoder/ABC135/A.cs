using System;
using System.Linq;

namespace Atcoder.ABC135
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split((' ')).Select(int.Parse).ToArray();
            var A = first[0];
            var B = first[1];
            int tmp = 0;
            if (A > B)
            {
                tmp = A - B;
            }
            else
            {
                tmp = B - A;
            }

            if (tmp % 2 == 0)
            {
                Console.WriteLine(tmp / 2);
            }
            else
            {
                Console.WriteLine("IMPOSSIBLE ");
            }
        }
    }
}