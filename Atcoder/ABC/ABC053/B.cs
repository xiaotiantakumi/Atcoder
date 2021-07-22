using System;
using CoderCommon;

namespace Atcoder.ABC053
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Read();
            var startPos = s.IndexOf('A');
            var endPos = s.LastIndexOf('Z');
            Console.WriteLine(endPos - startPos + 1);
        }
    }
}