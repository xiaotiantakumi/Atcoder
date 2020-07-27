using System;
using System.Linq;

namespace Atcoder.OtherCon.MSOLUTIONS_プロコンオープン_2020
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABC[0];
            var B = ABC[1];
            var C = ABC[2];

            var K = int.Parse(Console.ReadLine());
            for (int i = 0; i <= K; i++)
            {
                if (C > B && B > A)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                if (B <= A)
                {
                    B *= 2;
                    continue;
                }

                if (C <= B)
                {
                    C *= 2;
                    continue;
                }
            }

            Console.WriteLine("No");
        }
    }
}