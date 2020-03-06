using System;
using System.Linq;

namespace Atcoder.ABC131
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var C = input[2];
            var D = input[3];
            var CdivideCount = (B / C) - ((A - 1) / C);
            var DdivideCount = (B / D) - ((A - 1) / D);
            var CDdivideCount = (B / (C * D)) - ((A - 1) / (C * D));
            var len = B - A + 1;
            var ret = len - (CdivideCount + DdivideCount - CDdivideCount);
            Console.WriteLine(ret);
        }
    }
}