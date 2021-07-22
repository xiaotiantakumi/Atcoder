using System;
using CoderCommon;

namespace Atcoder.ABC.ABC177
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            var count = S.Length - T.Length;
            int retMatch = -1;
            for (int i = 0; i <= count; i++)
            {
                int cntMatch = 0;
                for (int j = 0; j < T.Length; j++)
                {
                    if (S[i + j] == T[j])
                    {
                        cntMatch++;
                    }
                }
                retMatch = Math.Max(retMatch, cntMatch);
            }

            Console.WriteLine(T.Length - retMatch);
        }
    }
}