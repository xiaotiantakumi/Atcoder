using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC190
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var conditions = new List<List<int>>();
            for (int i = 0; i < NM[1]; i++)
            {
                conditions.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            }

            var K = int.Parse(Console.ReadLine());
            List<int[]> cds = new List<int[]>();
            for (int i = 0; i < K; i++)
            {
                var CD = Console.ReadLine().Split().Select(int.Parse).ToArray();
                cds.Add(CD);
            }

            // {0, 1, ..., n-1} の部分集合の全探索
            int n = K;
            int result = 0;
            for (int bit = 0; bit < (1 << n); ++bit)
            {
                int tmpRet = 0;
                HashSet<int> hashset = new HashSet<int>();
                for (int i = 0; i < n; ++i)
                {
                    if ((bit & (1 << i)) != 0)
                    {
                        hashset.Add(cds[i][1]);
                    }
                    else
                    {
                        hashset.Add(cds[i][0]);
                    }
                }

                foreach (var cnd in conditions)
                {
                    if (hashset.Contains(cnd[0]) && hashset.Contains(cnd[1]))
                    {
                        tmpRet++;
                    }
                }

                result = Math.Max(result, tmpRet);
            }

            Console.WriteLine(result);
        }
    }
}