using System;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2019
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var K = int.Parse(Console.ReadLine());
            var c = S[K - 1];
            string ret = string.Empty;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == c)
                {
                    ret += c;
                }
                else
                {
                    ret += "*";
                }
            }

            Console.WriteLine(ret);
        }
    }
}