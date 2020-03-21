using System;
using System.Linq;

namespace Atcoder.ABC098
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = firstLine[0];
            var B = firstLine[1];
            var sum = A + B;
            var minus = A - B;
            var multi = A * B;
            Console.WriteLine(Math.Max(Math.Max(sum, minus), multi));
        }
    }
}