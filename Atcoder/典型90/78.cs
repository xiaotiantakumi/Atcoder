using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.典型90
{
    public class No78 : AtcoderBase
    {
        public override  void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < NM[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!dic.ContainsKey(ab[0])) dic.Add(ab[0], 0);
                if (!dic.ContainsKey(ab[1])) dic.Add(ab[1], 0);
                if (ab[0] > ab[1]) dic[ab[0]]++;
                if (ab[1] > ab[0]) dic[ab[1]]++;
            }

            Console.WriteLine(dic.Values.Count(x => x == 1));
        }
    }
}
