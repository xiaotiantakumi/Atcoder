using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.典型90
{
    public class No22 : CoderBase
    {
        public override  void Run()
        {
            var abc = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var gcd = Gcd(Gcd(abc[0], abc[1]), abc[2]);
            long ret = 0;
            ret += abc[0] / gcd - 1;
            ret += abc[1] / gcd - 1;
            ret += abc[2] / gcd - 1;
            Console.WriteLine(ret);
        }
    }
}