using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC150
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(500 * r[0] >= r[1] ? "Yes" : "No");
        }
    }
}