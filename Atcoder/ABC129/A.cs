using System;
using System.Linq;

namespace Atcoder.ABC129
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(firstLine[0] + firstLine[1]);
        }
    }
}