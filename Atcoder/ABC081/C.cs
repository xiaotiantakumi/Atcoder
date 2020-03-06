using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC081
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = f[0];
            var K = f[1];
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!dic.ContainsKey(r[i]))
                {
                    dic.Add(r[i], 1);
                }
                else
                {
                    dic[r[i]]++;
                }
            }

            int ret = 0;
            if (dic.Keys.Count > K)
            {
                var tmpList = dic.Values.OrderBy(x => x).ToList();
                ret += tmpList.Take(dic.Keys.Count - K).Sum();
            }
            Console.WriteLine(ret);
        }
    }
}