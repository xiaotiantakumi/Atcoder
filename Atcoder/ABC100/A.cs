using System;
using System.Linq;

namespace Atcoder.ABC100
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = firstLine[0];
            var B = firstLine[1];
            if (Math.Abs(A - B) > 1)
            {
                Console.WriteLine(":(");
            }
            else
            {
                Console.WriteLine("Yay!");
            }
        }
    }
}