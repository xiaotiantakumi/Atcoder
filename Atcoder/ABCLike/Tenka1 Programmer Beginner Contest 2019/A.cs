using System;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2019
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = Console.ReadLine().Split(' ');
            var A = int.Parse(N[0]);
            var B = int.Parse(N[1]);
            var C = int.Parse(N[2]);
            if (((A < C && C < B) || (B < C && C < A)))
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}