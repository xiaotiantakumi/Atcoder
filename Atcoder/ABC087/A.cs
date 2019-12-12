using System;

namespace Atcoder.ABC087
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var X = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            Console.WriteLine((X - A) % B);
        }
    }
}