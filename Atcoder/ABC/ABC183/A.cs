using System;
using CoderCommon;

namespace Atcoder.ABC.ABC183
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(x < 0 ? 0 : x);
        }
    }
}