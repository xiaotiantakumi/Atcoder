using System;
using System.Linq;

namespace Atcoder.ABC153
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = r[0];
            var N = r[1];
            var r2 = Console.ReadLine().Split().Select(long.Parse).Sum();
            if (H > r2)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}