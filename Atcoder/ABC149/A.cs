using System;
using System.Linq;

namespace Atcoder.ABC149
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().ToArray();
            Console.WriteLine(r[1] + r[0]);
        }
    }
}