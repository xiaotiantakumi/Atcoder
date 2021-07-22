using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC088
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var c1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i <= c1[0]; i++)
            {
                var b1 = c1[0] - i;
                var b2 = c1[1] - i;
                var b3 = c1[2] - i;

                if (c2[0] - b1 == c2[1] - b2 &&
                    c2[0] - b1 == c2[2] - b3 &&
                    c3[0] - b1 == c3[1] - b2 &&
                    c3[0] - b1 == c3[2] - b3)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}