using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC067
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ret = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(r[1]).Sum();
            Console.WriteLine(ret);
        }
    }
}