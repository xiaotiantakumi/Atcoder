using System;
using CoderCommon;

namespace Atcoder.ABC.ABC168
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            if (K >= S.Length)
            {
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine(S.Substring(0, K) + "...");
            }
        }
    }
}