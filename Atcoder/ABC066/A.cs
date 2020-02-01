using System;
using System.Linq;

namespace Atcoder.ABC066
{
    public class A : IAtcoder
    {
        public void Run()
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).Take(2).Sum());
        }
    }
}