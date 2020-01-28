using System;

namespace Atcoder.ABC070
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine();
            if (r[0] == r[2])
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