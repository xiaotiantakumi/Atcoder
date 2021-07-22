using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC178
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var abcd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ret1 = abcd[0] * abcd[2];
            var ret2 = abcd[0] * abcd[3];
            var ret3 = abcd[1] * abcd[2];
            var ret4 = abcd[1] * abcd[3];
            Console.WriteLine(Math.Max(Math.Max(Math.Max(ret1, ret2), ret3), ret4));
        }
    }
}