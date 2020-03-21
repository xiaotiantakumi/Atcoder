using System;

namespace Atcoder.ABC157
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = ReadInt();
            Console.WriteLine(N % 2 == 0 ? N / 2 : N / 2 + 1);
        }
    }
}