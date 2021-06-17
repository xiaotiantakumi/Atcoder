using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC200
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            // 途中。
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                var tmp = As[i] % 200;
                if (!dic.ContainsKey(tmp))
                {
                    dic[tmp] = 0;
                }
                else
                {
                    dic[tmp]++;
                }
            }

            Console.WriteLine(dic.Values.Count());
        }
    }
}