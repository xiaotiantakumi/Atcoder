using System;
using System.Linq;

namespace Atcoder.ABC146
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var X = input[2];

            long min = 0;
            long max = 1000000001;
            long mid = 0;

            while (max - min > 1)
            {
                mid = (min + max) / 2;
                var price = A * mid + B * mid.ToString().Length;
                if (X >= price)
                {
                    min = mid;
                }
                else
                {
                    max = mid;
                }
            }
            Console.WriteLine(min);
        }
    }
}