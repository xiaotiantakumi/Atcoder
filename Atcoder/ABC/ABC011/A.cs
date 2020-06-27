using System;

namespace Atcoder.ABC.ABC011
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N == 12 ? 1 : N + 1);
        }
    }
}