using System;
using System.Linq;

namespace Atcoder.ABC082
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = r[0] + r[1];
            Console.WriteLine((sum + 2 - 1) / 2);
        }
    }
}