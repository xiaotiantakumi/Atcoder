using System;
using CoderCommon;

namespace Atcoder.ABC.ABC011
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(N == 12 ? 1 : N + 1);
        }
    }
}