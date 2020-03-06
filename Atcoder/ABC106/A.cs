using System;
using System.Linq;

namespace Atcoder.ABC106
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine((input[0] - 1) * (input[1] - 1));
        }
    }
}