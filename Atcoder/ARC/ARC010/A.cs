using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC010
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var NMAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NMAB[0];
            var M = NMAB[1];
            var A = NMAB[2];
            var B = NMAB[3];

            for (int i = 0; i < M; i++)
            {
                var c = int.Parse(Console.ReadLine());
                if (N <= A)
                {
                    N += B;
                }

                N -= c;
                if (N < 0)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine("complete");
        }
    }
}