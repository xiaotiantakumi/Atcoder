using System;
using CoderCommon;

namespace Atcoder.ABC158
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NAB = ReadLongArray();
            var div = NAB[0] / (NAB[1] + NAB[2]);
            var lastBlue = NAB[0] % (NAB[1] + NAB[2]);
            lastBlue = lastBlue >= NAB[1] ? NAB[1] : lastBlue;
            Console.WriteLine(div * NAB[1] + lastBlue);
        }
    }
}