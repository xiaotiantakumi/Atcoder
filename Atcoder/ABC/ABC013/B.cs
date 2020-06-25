using System;

namespace Atcoder.ABC.ABC013
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var big = Math.Max(A, B);
            var small = Math.Min(A, B);

            Console.WriteLine(Math.Min(small + (10 - big), Math.Abs(big - small)));
        }
    }
}