using System;
using System.Linq;

namespace Atcoder.ABC130
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (first[0] < first[1])
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(10);
            }
        }
    }
}