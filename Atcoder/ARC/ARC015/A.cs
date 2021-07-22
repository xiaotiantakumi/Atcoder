using System;
using CoderCommon;

namespace Atcoder.ARC.ARC015
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(9.0 / 5.0 * n + 32.0);
        }
    }
}