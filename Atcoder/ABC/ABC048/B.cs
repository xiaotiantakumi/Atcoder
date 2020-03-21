using System;

namespace Atcoder.ABC048
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var abx = ReadLongArray();
            var bDiv = abx[1] / abx[2];
            long aDiv = -1;
            if (abx[0] != 0)
            {
                aDiv = (abx[0] - 1) / abx[2];
            }

            Console.WriteLine(bDiv - aDiv);
        }
    }
}