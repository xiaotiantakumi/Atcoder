using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC073
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                var r = int.Parse(Console.ReadLine());
                if (!dic.ContainsKey(r))
                {
                    dic[r] = 1;
                }
                else
                {
                    if (dic[r] == 1)
                    {
                        dic[r] = 2;
                    }
                    else
                    {
                        dic[r] = 1;
                    }

                }
            }
            Console.WriteLine(dic.Values.Where(x => x % 2 != 0).Sum());
        }
    }
}