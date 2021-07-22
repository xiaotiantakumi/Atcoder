using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC110
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < S.Length; i++)
            {
                if (dic.ContainsKey(S[i].ToString()))
                {
                    if (dic[S[i].ToString()] != T[i].ToString())
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    dic.Add(S[i].ToString(), T[i].ToString());
                    if (S[i] != T[i] && !dic.ContainsKey(T[i].ToString()))
                    {
                        dic.Add(T[i].ToString(), S[i].ToString());
                    }
                }
            }
            Console.WriteLine("Yes");
        }
    }
}