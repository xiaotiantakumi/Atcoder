using System;

namespace Atcoder.ABC099
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N >= 1000)
            {
                Console.WriteLine("ABD");
            }
            else
            {
                Console.WriteLine("ABC");
            }
        }
    }
}