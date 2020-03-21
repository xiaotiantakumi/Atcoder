using System;
using System.Linq;

namespace Atcoder.ABC065
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var X = r[0];
            var A = r[1];
            var B = r[2];
            var over = B - A;
            if (over <= 0)
            {
                Console.WriteLine("delicious");
            }
            else if (X >= over)
            {
                Console.WriteLine("safe");
            }
            else
            {
                Console.WriteLine("dangerous");
            }
        }
    }
}