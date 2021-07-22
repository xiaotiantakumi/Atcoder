using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC107
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(input[0] - input[1] + 1);
        }
    }
}