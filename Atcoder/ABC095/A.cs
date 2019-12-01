using System;
using System.Linq;

namespace Atcoder.ABC095
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var S = Console.ReadLine().ToList().Count(x => x == 'o');
            Console.WriteLine(700 + (100 * S));
        }
    }
}