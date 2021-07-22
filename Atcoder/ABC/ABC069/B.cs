using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC069
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            var len = r.Length - 2;
            Console.WriteLine(r.First().ToString() + len.ToString() + r.Last().ToString());
        }
    }
}