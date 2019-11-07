using System;

namespace Atcoder.ABC139
{
    public class A : IAtcoder
    {
        public void Run()
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