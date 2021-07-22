using System;
using CoderCommon;

namespace Atcoder.ABC156
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = ReadIntArray();
            var N = r[0];
            var R = r[1];

            if (N < 10)
            {
                Console.WriteLine(R + (100 * (10 - N)));
            }
            else
            {
                Console.WriteLine(R);
            }
        }
    }
}