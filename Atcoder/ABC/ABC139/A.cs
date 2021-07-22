using System;
using CoderCommon;

namespace Atcoder.ABC139
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            int ret = 0;
            for (int i = 0; i < 3; i++)
            {
                if (S[i] == T[i])
                {
                    ret++;
                }
            }
            Console.Write(ret);
        }
    }
}