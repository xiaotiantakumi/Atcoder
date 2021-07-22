using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC171
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(prices.Take(NK[1]).Sum());
        }
    }
}