using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC033
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            var first = r.First();
            Console.WriteLine(r.All(x => x == first) ? "SAME" : "DIFFERENT");
        }
    }
}