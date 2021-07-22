using System;
using CoderCommon;

namespace Atcoder.ABC.ABC181
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N % 2 == 0 ? "White" : "Black");
        }
    }
}