using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC151
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = r1[0];
            var M = r1[1];
            int acCount = 0;
            int waCount = 0;
            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
            for (int i = 0; i < M; i++)
            {
                var r = Console.ReadLine().Split().Select(x => x).ToArray();
                if (!dic.ContainsKey(r[0]))
                {
                    if (r[1] == "WA")
                    {
                        dic.Add(r[0], new int[2] { 0, 1 });
                        waCount++;
                    }
                    else
                    {
                        dic.Add(r[0], new int[2] { 1, 0 });
                        acCount++;
                    }
                }
                else if (dic[r[0]][0] == 0)
                {
                    if (r[1] == "WA")
                    {
                        dic[r[0]][1]++;
                        waCount++;
                    }
                    else
                    {
                        dic[r[0]][0]++;
                        acCount++;
                    }
                }
            }

            var ret = string.Format("{0} {1}", acCount, waCount);
            Console.WriteLine(ret);
        }
    }
}