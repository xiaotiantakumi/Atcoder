using System;
using CoderCommon;

namespace Atcoder.ABC.ABC163
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(r * 2 * Math.PI);
        }
    }
}