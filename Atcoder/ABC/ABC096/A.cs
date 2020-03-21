using System;
using System.Linq;

namespace Atcoder.ABC096
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (r[0] <= r[1])
            {
                Console.WriteLine(r[0]);
            }
            else
            {
                Console.WriteLine(r[0] - 1);
            }
        }
    }
}