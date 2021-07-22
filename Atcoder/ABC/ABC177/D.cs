using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC177
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < NM[1]; i++)
            {
                var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (dic.Count > 0)
                {
                    bool flg = false;
                    foreach (var pair in dic)
                    {
                        if (pair.Value.Contains(AB[0]) || pair.Value.Contains(AB[1]))
                        {
                            pair.Value.Add(AB[0]);
                            pair.Value.Add(AB[1]);
                            flg = true;
                            break;
                        }
                    }

                    if (!flg)
                    {
                        dic.Add(AB[0], new HashSet<int>() { AB[0], AB[1] });
                    }
                }
                else
                {
                    dic.Add(AB[0], new HashSet<int>() { AB[0], AB[1] });
                }
            }

            int ret = 0;
            foreach (var pairs in dic)
            {
                ret = Math.Max(ret, pairs.Value.Count);
            }
            Console.WriteLine(ret);
        }
    }
}