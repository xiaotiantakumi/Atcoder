using System;
using CoderCommon;

namespace Atcoder.ABCLike
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var A = Console.ReadLine().Length;
            var B = Console.ReadLine().Length;
            Console.WriteLine(A * B);
        }
    }
}