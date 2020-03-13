using System;

namespace Atcoder.ABC050
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadStringArray();
            var A = int.Parse(r[0]);
            var B = int.Parse(r[2]);
            if (r[1] == "+")
            {
                Console.WriteLine(A + B);
            }
            else
            {
                Console.WriteLine(A - B);
            }
        }
    }
}