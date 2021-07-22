using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC185
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NMT = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NMT[0];
            var current = NMT[0];
            var M = NMT[1];
            var T = NMT[2];
            int pos = 0;
            for (int i = 0; i < M; i++)
            {
                var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
                current -= AB[0] - pos;
                if (current <= 0)
                {
                    Console.WriteLine("No");
                    return;
                }
                // バッテリー残量の上限があるのを忘れてたので何度か不正解
                current = Math.Min(N, current + AB[1] - AB[0]);
                pos = AB[1];
            }

            current -= (T - pos);
            if (current <= 0)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine("Yes");
        }
    }
}