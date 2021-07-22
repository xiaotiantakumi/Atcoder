using System;
using CoderCommon;

namespace yukicoder.Contents
{
    public class No1591 : CoderBase
    {
        public override void Run()
        {
            var N = Console.ReadLine();
            Console.WriteLine(N.Length == 2 ? "Yes" : "No");
        }
    }
}