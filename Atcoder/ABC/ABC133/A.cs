using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC133
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = first[0] * first[1];
            if (a <= first[2])
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(first[2]);
            }
        }
    }
}