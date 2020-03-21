using System;
using System.Linq;

namespace Atcoder.ABC048
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadStringArray();
            Console.WriteLine("A" + r[1].First() + "C");
        }
    }
}