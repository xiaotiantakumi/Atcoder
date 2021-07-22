using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC190
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABC[0];
            var B = ABC[1];
            var C = ABC[2];
            var isA = C == 0 ? true : false;
            while (true)
            {
                if (isA)
                {
                    A--;
                }
                else
                {
                    B--;
                }

                isA = !isA;
                if (A < 0)
                {
                    Console.WriteLine("Aoki");
                    return;
                }

                if (B < 0)
                {
                    Console.WriteLine("Takahashi");
                    return;
                }
            }
        }
    }
}