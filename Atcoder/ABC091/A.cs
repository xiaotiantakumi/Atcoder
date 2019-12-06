using System;
using System.Linq;

namespace Atcoder.ABC091
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (l[2] <= l[0] + l[1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}