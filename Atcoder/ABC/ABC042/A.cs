using System;
using System.Linq;

namespace Atcoder.ABC042
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = r.Count(x => x == 5) == 2 && r.Any(x => x == 7);
            Console.WriteLine(ret ? "YES" : "NO");
        }
    }
}