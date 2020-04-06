using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC041
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                dic.Add(i + 1, As[i]);
            }

            foreach (var item in dic.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}