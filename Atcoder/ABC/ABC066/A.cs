using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC066
{
    public class A : CoderBase
    {
        public override void Run()
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).Take(2).Sum());
        }
    }
}