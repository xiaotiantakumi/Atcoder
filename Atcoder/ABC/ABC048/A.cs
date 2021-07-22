using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC048
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = ReadStringArray();
            Console.WriteLine("A" + r[1].First() + "C");
        }
    }
}