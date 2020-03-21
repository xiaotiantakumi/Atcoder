using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC082
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int rmCount = 0;
            for (int i = 0; i < N; i++)
            {
                if (dic.ContainsKey(r[i]))
                {
                    if (dic[r[i]] >= r[i])
                    {
                        rmCount++;
                        continue;
                    }
                    dic[r[i]]++;
                }
                else
                {
                    dic.Add(r[i], 1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Key > item.Value)
                {
                    rmCount += item.Value;
                }
            }
            Console.WriteLine(rmCount);
        }
    }
}