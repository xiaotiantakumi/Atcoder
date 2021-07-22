using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC.ABC193
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var limit = Math.Sqrt(N);
            HashSet<long> lst = new HashSet<long>();
            for (int i = 2; i <= limit; i++)
            {
                int cur = 2;
                while (true)
                {
                    var tmp = Math.Pow(i, cur);
                    if (tmp > N)
                    {
                        break;
                    }
                    lst.Add((long)tmp);
                    cur++;
                }
            }

            Console.WriteLine(N - lst.Count);
        }
    }
}