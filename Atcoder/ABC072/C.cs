using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC072
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var len = r.Max();
            int ret = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!dic.ContainsKey(r[i]))
                {
                    dic.Add(r[i], 1);
                }
                else
                {
                    dic[r[i]]++;
                }
            }

            for (int i = 0; i <= len; i++)
            {
                int tmpRet = 0;
                if (dic.ContainsKey(i - 1))
                {
                    tmpRet += dic[i - 1];
                }
                if (dic.ContainsKey(i))
                {
                    tmpRet += dic[i];
                }
                if (dic.ContainsKey(i + 1))
                {
                    tmpRet += dic[i + 1];
                }

                if (ret <= tmpRet)
                {
                    ret = tmpRet;
                }
            }

            Console.WriteLine(ret);
        }
    }
}