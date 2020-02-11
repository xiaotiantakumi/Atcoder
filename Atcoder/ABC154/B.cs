using System;
using System.Linq;

namespace Atcoder.ABC154
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var S = Read();
            Enumerable.Repeat("x", S.Length).ToList().ForEach(x => Console.Write(x));
        }
    }
}