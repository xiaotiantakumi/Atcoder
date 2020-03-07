using System;

namespace Atcoder.ABC053
{
    public class A : AtcoderBase
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