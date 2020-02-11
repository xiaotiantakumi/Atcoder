using System;
using System.Collections.Generic;

namespace Atcoder.ABC154
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r1 = ReadStringArray();
            var r2 = ReadIntArray();
            Dictionary<string, int> ret = new Dictionary<string, int>();
            ret.Add(r1[0], r2[0]);
            ret.Add(r1[1], r2[1]);
            var remove = Read();
            --ret[remove];
            List<string> outRet = new List<string>();
            foreach (var item in ret)
            {
                outRet.Add(item.Value.ToString());
            }

            Console.WriteLine(string.Join(" ", outRet));
        }
    }
}