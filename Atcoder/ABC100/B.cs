using System;
using System.Linq;

namespace Atcoder.ABC100
{
    public class B : IAtcoder
    {
        public void Run()
        {
            // まだ正答できてない。解説見て理解してから。
            // 100の時だけ違う動きさせないといけないようだけど、なぜかわからない。
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var D = firstLine[0];
            var N = firstLine[1];
            var tmp = Math.Pow(100, D);
            Console.WriteLine(tmp * N);
        }
    }
}