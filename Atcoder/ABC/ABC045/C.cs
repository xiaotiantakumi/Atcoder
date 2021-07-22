using System;
using CoderCommon;

namespace Atcoder.ABC045
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            // {0, 1, ..., n-1} の部分集合の全探索
            int n = S.Length - 1;
            long sum = 0;
            for (int bit = 0; bit < (1 << n); ++bit)
            {
                string part = S[0].ToString();
                for (int i = 0; i < n; ++i)
                {
                    if ((bit & (1 << i)) != 0)
                    {
                        sum += long.Parse(part);
                        part = S[i + 1].ToString();
                    }
                    else
                    {
                        part += S[i + 1];
                    }
                }

                sum += long.Parse(part);
            }

            Console.WriteLine(sum);
        }
    }
}