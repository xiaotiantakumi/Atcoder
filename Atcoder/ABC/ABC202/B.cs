using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC202
{
    public class B : CoderBase
    {
        public override void Run()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"0","0"},
                {"1","1"},
                {"6","9"},
                {"8","8"},
                {"9","6"},
            };
            string ret = string.Empty;
            var s = Console.ReadLine();
            foreach (var item in s)
            {
                ret += dic[item.ToString()];
            }

            Console.WriteLine(new string(ret.Reverse().ToArray()));
        }
    }
}