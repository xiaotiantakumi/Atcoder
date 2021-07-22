using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC102
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(inputs[inputs.Length - 1] - inputs[0]);
        }
    }
}