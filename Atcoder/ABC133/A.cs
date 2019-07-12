using System;
using System.Linq;

namespace Atcoder.ABC133
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = first[0] * first[1];
            if (a <= first[2])
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(first[2]);
            }
        }
    }
}