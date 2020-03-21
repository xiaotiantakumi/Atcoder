using System;

namespace Atcoder.ABC147
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine().ToCharArray();
            int ret = 0;
            int len = S.Length / 2;
            for (int i = 0; i < len; i++)
            {
                if (S[i] != S[S.Length - 1 - i])
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}