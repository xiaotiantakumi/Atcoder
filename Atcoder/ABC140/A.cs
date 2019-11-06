using System;

namespace Atcoder.ABC140
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N * N * N);
        }
    }
}