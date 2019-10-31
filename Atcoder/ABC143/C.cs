using System;

namespace Atcoder.ABC143
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var lenS = S.Length;
            long ret = 1;
            for (int i = 1; i <= lenS - 1; i++)
            {
                if (S[i - 1] != S[i])
                {
                    ret += 1;
                }
            }
            Console.Write(ret);
        }
    }
}