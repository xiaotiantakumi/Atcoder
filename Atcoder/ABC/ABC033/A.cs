using System;
using System.Linq;

namespace Atcoder.ABC.ABC033
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            var first = r.First();
            Console.WriteLine(r.All(x => x == first) ? "SAME" : "DIFFERENT");
        }
    }
}