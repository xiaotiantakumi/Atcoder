using System;
using System.Linq;

namespace Atcoder.ABC137
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var ret = Math.Max(A + B, (Math.Max(A - B, A * B)));
            Console.WriteLine(ret);
        }
    }
}