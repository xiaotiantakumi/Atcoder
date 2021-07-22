using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC153
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = (r[0] + (r[1] - 1)) / r[1];
            Console.WriteLine(ret);
        }
    }
}