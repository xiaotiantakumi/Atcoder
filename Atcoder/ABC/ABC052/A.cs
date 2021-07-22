using System;
using CoderCommon;

namespace Atcoder.ABC052
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var abcd = ReadIntArray();
            Console.WriteLine(Math.Max(abcd[0] * abcd[1], abcd[2] * abcd[3]));
        }
    }
}