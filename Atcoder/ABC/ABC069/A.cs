using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC069
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine((r[0] - 1) * (r[1] - 1));
        }
    }
}