using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC130
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (first[0] < first[1])
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(10);
            }
        }
    }
}