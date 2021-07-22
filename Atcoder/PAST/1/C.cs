using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.PAST._1
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(array[2]);
        }
    }
}