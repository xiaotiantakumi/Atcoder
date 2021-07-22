using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ARC.ARC019
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('O', '0');
            dic.Add('D', '0');
            dic.Add('I', '1');
            dic.Add('Z', '2');
            dic.Add('S', '5');
            dic.Add('B', '8');
            var s = Console.ReadLine();
            string ret = string.Empty;
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    ret += dic[c];
                }
                else
                {
                    ret += c;
                }
            }

            Console.WriteLine(ret);
        }
    }
}