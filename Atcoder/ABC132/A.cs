using System;
using System.Linq;

namespace Atcoder.ABC132
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var S = Console.ReadLine();

            foreach (var c in S)
            {
                if (S.Where(x => x == c).Count() != 2)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}