using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC210
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Cs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = Cs.Take(NK[1]);
            var current = new HashSet<int>(list).Count;
            var queue = new Queue<int>(list);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var key in list)
            {
                if (!dic.ContainsKey(key)) dic[key] = 0;
                dic[key]++;
            }
            int ret = current;
            for (int i = NK[1]; i < NK[0]; i++)
            {
                var remove = queue.Dequeue();
                if (dic[remove] > 0) --dic[remove];
                if (dic[remove] == 0) current--;
                if (!dic.ContainsKey(Cs[i]) || dic[Cs[i]] == 0)
                {
                    dic[Cs[i]] = 0;
                    current++;
                }
                dic[Cs[i]]++;
                queue.Enqueue(Cs[i]);
                ret = Math.Max(ret, current);
            }
            Console.WriteLine(ret);
        }
    }
}