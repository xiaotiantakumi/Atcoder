using System;

namespace Atcoder.ABC093
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            if (S.Contains("a") &&
                S.Contains("b") &&
                S.Contains("c"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}