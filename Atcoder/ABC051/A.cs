using System;

namespace Atcoder.ABC051
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var s = Read();
            Console.WriteLine(s.Replace(",", " "));
        }
    }
}