using System;

namespace Atcoder.ABCLike
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var A = Console.ReadLine().Length;
            var B = Console.ReadLine().Length;
            Console.WriteLine(A * B);
        }
    }
}