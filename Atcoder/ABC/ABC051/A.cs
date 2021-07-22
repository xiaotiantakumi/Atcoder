using System;
using CoderCommon;

namespace Atcoder.ABC051
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var s = Read();
            Console.WriteLine(s.Replace(",", " "));
        }
    }
}