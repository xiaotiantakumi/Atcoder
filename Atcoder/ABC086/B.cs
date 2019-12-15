using System;

namespace Atcoder.ABC086
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var r = int.Parse(Console.ReadLine().Replace(" ", string.Empty));
            for (int i = 1; i <= 1000; i++)
            {
                if (r == i * i)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}