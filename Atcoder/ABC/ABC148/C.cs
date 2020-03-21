using System;
using System.Linq;

namespace Atcoder.ABC148
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();
            for (int i = 1; i <= r[1]; i++)
            {
                var p = r[0] * i;
                if (p % r[1] == 0)
                {
                    Console.WriteLine(p);
                    return;
                }
            }
        }
    }
}