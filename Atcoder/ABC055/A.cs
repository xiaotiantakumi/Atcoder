using System;

namespace Atcoder.ABC055
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var cpon = N / 15;
            Console.WriteLine(N * 800 - 200 * cpon);
        }
    }
}