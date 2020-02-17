using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC155
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var S = Read();
                if (dic.ContainsKey(S))
                {
                    dic[S]++;
                }
                else
                {
                    dic[S] = 1;
                }
            }
            var dic2 = dic.OrderByDescending(x => x.Value);
            List<string> retList = new List<string>();
            foreach (var pair in dic2)
            {
                if (pair.Value == dic2.Max(x => x.Value))
                {
                    retList.Add(pair.Key);
                }
            }

            foreach (var ret in retList.OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine(ret);
            }
        }
    }
}