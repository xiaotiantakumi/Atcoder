using System;
using CoderCommon;

namespace Atcoder.ABC041
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(S[r - 1]);
        }
    }
}