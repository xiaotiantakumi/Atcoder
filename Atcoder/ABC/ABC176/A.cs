using System;
using System.Linq;

namespace Atcoder.ABC.ABC176
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var times = Math.Ceiling(NXT[0] / NXT[1]);
            Console.WriteLine(times * NXT[2]);
        }
    }
}