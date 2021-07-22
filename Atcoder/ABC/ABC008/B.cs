using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC008
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var name = Console.ReadLine();
                if (dic.ContainsKey(name))
                {
                    dic[name]++;
                }
                else
                {
                    dic[name] = 0;
                }
            }
            var ret = dic.OrderByDescending(x => x.Value).ToList().First();
            Console.WriteLine(ret.Key);
        }
    }
}