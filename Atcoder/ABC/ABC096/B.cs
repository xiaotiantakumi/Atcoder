using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC096
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
            var k = int.Parse(Console.ReadLine());
            var max = f[2];
            var calVal = max * Math.Pow(2, k);
            var ret = f[0] + f[1] + calVal;
            Console.WriteLine(ret);
        }
    }
}