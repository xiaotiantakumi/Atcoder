using System;
using System.Linq;

namespace Atcoder.ABC.ABC185
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Console.WriteLine(r.Min());
        }
    }
}