using System;
using System.Linq;

namespace Atcoder.ABC089
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var r = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split(' ');
            if (l.Any(x => x == "Y"))
            {
                Console.WriteLine("Four");
            }
            else
            {
                Console.WriteLine("Three");

            }
        }
    }
}