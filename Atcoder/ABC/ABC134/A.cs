using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC134
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(3 * r * r);
        }
    }
}