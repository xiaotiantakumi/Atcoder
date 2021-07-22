using System;
using CoderCommon;

namespace Atcoder.ABC104
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var R = int.Parse(Console.ReadLine());
            if (R < 1200)
            {
                Console.WriteLine("ABC");
            }
            else if (R < 2800)
            {
                Console.WriteLine("ARC");
            }
            else
            {
                Console.WriteLine("AGC");
            }
        }
    }
}