using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC107
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var div = 998244353;
            var ABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var aSum = (ABC[0] * (ABC[0] + 1) / 2) % div;
            var bSum = (ABC[1] * (ABC[1] + 1) / 2) % div;
            var cSum = (ABC[2] * (ABC[2] + 1) / 2) % div;
            long ret = aSum * bSum % div;
            ret = ret * cSum % div;
            Console.WriteLine(ret);
        }
    }
}