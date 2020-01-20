using System;
using System.Linq;

namespace Atcoder.ABC152
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] == r[1])
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