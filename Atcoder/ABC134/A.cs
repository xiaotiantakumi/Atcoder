using System;
using System.Linq;

namespace Atcoder.ABC134
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(3 * r * r);
        }
    }
}