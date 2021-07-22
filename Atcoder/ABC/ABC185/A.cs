using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC185
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Console.WriteLine(r.Min());
        }
    }
}