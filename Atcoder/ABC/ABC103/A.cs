using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC103
{
    public class A : CoderBase
    {
        public override void Run()
        {   
            var input = Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(input[1] - input[0] + input[2] - input[1]);
        }
    }
}