using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ARC.ARC008
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var name = Console.ReadLine();
            var kit = Console.ReadLine();
            Dictionary<char, int> dicName = new Dictionary<char, int>();
            Dictionary<char, int> dicKits = new Dictionary<char, int>();
            foreach (var s in name)
            {
                if (dicName.ContainsKey(s))
                {
                    dicName[s]++;
                }
                else
                {
                    dicName[s] = 1;
                }
            }
            foreach (var s in kit)
            {
                if (dicKits.ContainsKey(s))
                {
                    dicKits[s]++;
                }
                else
                {
                    dicKits[s] = 1;
                }
            }

            int ret = 0;
            foreach (var namePair in dicName)
            {
                if (!dicKits.ContainsKey(namePair.Key))
                {
                    Console.WriteLine(-1);
                    return;
                }
                var tmp = (namePair.Value + dicKits[namePair.Key] - 1) / dicKits[namePair.Key];
                ret = Math.Max(ret, (int)tmp);
            }

            Console.WriteLine(ret);
        }
    }
}