using System;
using CoderCommon;

namespace Atcoder.ABC059
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var A = Read();
            var B = Read();
            var digit = Math.Max(A.Length, B.Length);
            A = A.PadLeft(digit, '0');
            B = B.PadLeft(digit, '0');
            if (A.CompareTo(B) < 0)
            {
                Console.WriteLine("LESS");
            }
            else if (A.CompareTo(B) > 0)
            {
                Console.WriteLine("GREATER");
            }
            else
            {
                Console.WriteLine("EQUAL");
            }
        }
    }
}