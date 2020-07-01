using System;

namespace Atcoder.ABC.ABC009
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine((N + (2 - 1)) / 2);
        }
    }
}