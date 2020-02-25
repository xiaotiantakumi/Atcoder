using System;

namespace Atcoder.ABC056
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            if (r[0] + r[1] >= 24)
            {
                Console.WriteLine(r[0] + r[1] - 24);
            }
            else
            {
                Console.WriteLine(r[0] + r[1]);
            }
        }
    }
}