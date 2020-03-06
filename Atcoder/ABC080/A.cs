using System;
using System.Linq;

namespace Atcoder.ABC080
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(r[0] * r[1], r[2]));
        }
    }
}