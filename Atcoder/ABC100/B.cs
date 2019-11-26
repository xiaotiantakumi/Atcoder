using System;
using System.Linq;

namespace Atcoder.ABC100
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var D = firstLine[0];
            var N = firstLine[1];
            var tmp = Math.Pow(100, D);
            if (N == 100)
            {
                N++;
            }
            Console.WriteLine(tmp * N);
        }
    }
}