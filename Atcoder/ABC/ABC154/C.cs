using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC154
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var r = ReadIntArray().Distinct().Count();
            if (N == r)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}