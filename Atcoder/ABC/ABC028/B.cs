using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC.ABC028
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            Dictionary<char, int> ret = new Dictionary<char, int>();
            ret.Add('A', 0);
            ret.Add('B', 0);
            ret.Add('C', 0);
            ret.Add('D', 0);
            ret.Add('E', 0);
            ret.Add('F', 0);
            foreach (var s in S)
            {
                if (ret.ContainsKey(s))
                {
                    ret[s]++;
                }
            }
            Console.WriteLine(string.Join(" ", ret.Values));
        }
    }
}