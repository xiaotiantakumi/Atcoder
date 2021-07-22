using System;
using CoderCommon;

namespace Atcoder.ABC057
{
    public class A : CoderBase
    {
        public override void Run()
        {

            var r = ReadIntArray();
            if (r[0] + r[1] >= 24)
            {
                Console.WriteLine(r[0] + r[1] - 24);
            }
            else
            {
                Console.WriteLine(r[0] + r[1]);
            }
        }
    }
}