using System;

namespace Atcoder.ABC001
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var H1 = int.Parse(Console.ReadLine());
            var H2 = int.Parse(Console.ReadLine());
            Console.WriteLine(H1 - H2);
        }
    }
}