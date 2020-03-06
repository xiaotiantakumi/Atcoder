using System;
using System.Linq;

namespace Atcoder.ABC069
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine((r[0] - 1) * (r[1] - 1));
        }
    }
}