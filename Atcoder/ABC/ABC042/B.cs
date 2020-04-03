using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC042
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NL = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> strs = new List<string>();
            for (int i = 0; i < NL[0]; i++)
            {
                strs.Add(Console.ReadLine());
            }

            strs = strs.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();
            string ret = string.Empty;
            foreach (var str in strs)
            {
                ret += str;
            }

            Console.WriteLine(ret);
        }
    }
}