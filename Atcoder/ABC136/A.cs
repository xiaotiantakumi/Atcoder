using System;

namespace Atcoder.ABC136
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            if (a >= 3200)
            {
                Console.WriteLine(s);

            }
            else
            {
                Console.WriteLine("red");
            }
        }
    }
}