using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC163
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> ret = new Dictionary<int, int>();
            foreach (var item in As)
            {
                if (!ret.ContainsKey(item))
                {
                    ret[item] = 1;
                }
                else
                {
                    ret[item]++;
                }
            }

            for (int i = 1; i <= N; i++)
            {
                if (ret.TryGetValue(i, out int val))
                {
                    Console.WriteLine(val);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}