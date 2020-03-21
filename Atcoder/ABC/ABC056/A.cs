using System;

namespace Atcoder.ABC056
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var ab = ReadStringArray();
            if (ab[0] == "H")
            {
                Console.WriteLine(ab[1]);
            }
            else
            {
                if (ab[1] == "H")
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("H");
                }
            }
        }
    }
}