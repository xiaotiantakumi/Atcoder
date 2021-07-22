using System;
using CoderCommon;

namespace Atcoder.ABC053
{
    public class A : CoderBase
    {
        public override void Run()
        {
            if (ReadInt() < 1200)
            {
                Console.WriteLine("ABC");
            }
            else
            {
                Console.WriteLine("ARC");
            }
        }
    }
}