using System;
using System.Linq;

namespace Atcoder.ABC147
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (l[0] + l[1] + l[2] >= 22)
            {
                Console.WriteLine("bust");
            }
            else
            {
                Console.WriteLine("win");
            }
        }
    }
}