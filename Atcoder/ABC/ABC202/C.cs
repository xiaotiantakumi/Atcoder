using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC202
{
    public class C : CoderBase
    {
        public override void Run()
        {
            SourceExpander.Expander.Expand(ignoreAnyError: false);
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToList();
            var C = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> bAjustDic = new Dictionary<int, int>();
            foreach (var bIndex in C)
            {
                var index = bIndex - 1;
                var key = B[index];
                if (!bAjustDic.ContainsKey(key))
                {
                    bAjustDic[key] = 0;
                }
                bAjustDic[key]++;
            }

            decimal ret = 0;
            foreach (var current in A)
            {
                if (bAjustDic.ContainsKey(current))
                {
                    ret += bAjustDic[current];
                }
            }

            Console.WriteLine(ret);
        }
    }
}