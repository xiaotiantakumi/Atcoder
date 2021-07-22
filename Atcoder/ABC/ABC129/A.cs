using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC129
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(firstLine[0] + firstLine[1]);
        }
    }
}