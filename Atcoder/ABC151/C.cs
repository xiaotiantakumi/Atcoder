using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC151
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = r[0];
            var M = r[1];
            var acList = new HashSet<int>();
            Dictionary<int, int> waDic = new Dictionary<int, int>();
            for (int i = 0; i < M; i++)
            {
                var l = Console.ReadLine().Split().ToArray();
                var t = int.Parse(l[0]);
                var kekka = l[1];
                if (acList.Contains(t))
                {
                    continue;
                }
                if (kekka == "WA")
                {
                    if (!waDic.ContainsKey(t))
                    {
                        waDic.Add(t, 1);
                    }
                    else
                    {
                        waDic[t]++;
                    }
                }
                else if (kekka == "AC")
                {
                    acList.Add(t);
                }
            }

            var waCount = 0;
            foreach (var ac in acList)
            {
                if (waDic.ContainsKey(ac))
                {
                    waCount += waDic[ac];
                }

            }
            Console.WriteLine(acList.Count + " " + waCount);
        }
    }
}