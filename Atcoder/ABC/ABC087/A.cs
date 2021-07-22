using System;
using CoderCommon;

namespace Atcoder.ABC087
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var X = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            Console.WriteLine((X - A) % B);
        }
    }
}