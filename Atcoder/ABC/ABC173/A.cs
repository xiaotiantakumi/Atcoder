using System;
using CoderCommon;

namespace Atcoder.ABC.ABC173
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            N = N % 1000;
            Console.WriteLine(1000 - N == 1000 ? 0 : 1000 - N);
        }
    }
}