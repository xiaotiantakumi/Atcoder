using System;

namespace Atcoder.ABC041
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(S[r - 1]);
        }
    }
}