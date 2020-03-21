using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC061
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            Dictionary<int, int> roadDic = new Dictionary<int, int>();
            for (int i = 0; i < r[1]; i++)
            {
                var tmp = ReadIntArray();
                if (roadDic.ContainsKey(tmp[0]))
                {
                    roadDic[tmp[0]]++;
                }
                else
                {
                    roadDic.Add(tmp[0], 1);
                }
                if (roadDic.ContainsKey(tmp[1]))
                {
                    roadDic[tmp[1]]++;
                }
                else
                {
                    roadDic.Add(tmp[1], 1);
                }
            }

            foreach (var pair in roadDic.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}