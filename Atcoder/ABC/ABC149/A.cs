using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC149
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().ToArray();
            Console.WriteLine(r[1] + r[0]);
        }
    }
}