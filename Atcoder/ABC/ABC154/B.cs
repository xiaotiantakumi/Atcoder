using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC154
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Read();
            Enumerable.Repeat("x", S.Length).ToList().ForEach(x => Console.Write(x));
        }
    }
}