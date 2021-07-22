using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC069
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (NM[0] * 2 >= NM[1])
            {
                Console.WriteLine(Math.Truncate((double)NM[1] / 2));
            }
            else
            {
                var remain = NM[1] - NM[0] * 2;
                Console.WriteLine(NM[0] + Math.Truncate((double)remain / 4));
            }
        }
    }
}