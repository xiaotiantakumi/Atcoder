using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC078
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var X = r[0];
            var Y = r[1];
            var Z = r[2];
            var remain = X - (Y + 2 * Z);
            int ret = 1;
            while (remain >= Y + Z)
            {
                ret++;
                remain -= Y + Z;
            }
            Console.WriteLine(ret);
        }
    }
}