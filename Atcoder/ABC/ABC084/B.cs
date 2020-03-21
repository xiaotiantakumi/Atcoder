using System;
using System.Linq;

namespace Atcoder.ABC084
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var S = Console.ReadLine();
            int tmp = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[r[0]] != '-')
                {
                    Console.WriteLine("No");
                    return;
                }

                if (i == r[0])
                {
                    continue;
                }

                if (!int.TryParse(S[i].ToString(), out tmp))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}