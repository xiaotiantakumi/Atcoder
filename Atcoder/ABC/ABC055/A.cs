using System;
using CoderCommon;

namespace Atcoder.ABC055
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var cpon = N / 15;
            Console.WriteLine(N * 800 - 200 * cpon);
        }
    }
}