using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC201
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine().Split();
                dic.Add(r[0], int.Parse(r[1]));
            }

            var values = dic.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine(values[1]);
        }
    }
}