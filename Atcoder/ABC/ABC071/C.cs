using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC071
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();
            var ret = new List<long>();
            for (int i = 0; i < N - 1; i++)
            {
                if (r[i] == r[i + 1])
                {
                    ret.Add(r[i]);
                    i++;
                    if (ret.Count == 2)
                    {
                        Console.WriteLine(ret[0] * ret[1]);
                        return;
                    }
                }
            }
            Console.WriteLine(0);
        }
    }
}