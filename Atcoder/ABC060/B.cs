using System;

namespace Atcoder.ABC060
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            if (r[0] < r[1])
            {
                Console.WriteLine("YES");
                return;
            }
            if (r[0] - r[1] < r[2])
            {
                Console.WriteLine("NO");
                return;
            }

            if (r[0] == r[1])
            {
                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("YES");
        }
    }
}