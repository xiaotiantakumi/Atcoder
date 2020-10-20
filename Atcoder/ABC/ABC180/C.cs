using System;
using System.Collections.Generic;

namespace Atcoder.ABC.ABC180
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var sqrtN = Math.Sqrt(N);
            List<long> rets = new List<long>();
            for (int i = 1; i <= sqrtN; i++)
            {
                if (N % i == 0)
                {
                    rets.Add(i);
                }
            }

            var cnt = rets.Count;
            int cur = 0;
            for (var index = cnt - 1; index >= 0; index--)
            {
                var item = rets[index];
                if (item == sqrtN)
                {
                    continue;
                }
                rets.Add(N / item);
                cur++;
            }

            Console.WriteLine(string.Join("\n", rets));
        }
    }
}