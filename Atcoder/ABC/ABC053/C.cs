using System;

namespace Atcoder.ABC053
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            long r = ReadLong();
            var ret = r / 11;
            if (r <= 6)
            {
                Console.WriteLine(1);
                return;
            }
            else if (r <= 11)
            {
                Console.WriteLine(2);
                return;
            }

            if (r % 11 == 0)
            {
                Console.WriteLine(ret * 2);
                return;
            }

            if (r % 11 <= 6)
            {
                Console.WriteLine(ret * 2 + 1);
            }
            else
            {
                Console.WriteLine(ret * 2 + 2);
            }
        }
    }
}