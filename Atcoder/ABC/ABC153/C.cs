using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC153
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = r[0];
            var K = r[1];
            var ret = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).Skip(K).Sum();
            Console.WriteLine(ret);
        }
    }
}