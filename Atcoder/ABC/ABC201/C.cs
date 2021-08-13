using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC.ABC201
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            List<string> includes = new List<string>();
            List<string> notIncludes = new List<string>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'o')
                {
                    includes.Add(i.ToString());
                }
                else if (S[i] == 'x')
                {
                    notIncludes.Add(i.ToString());
                }
            }

            int ret = 0;
            for (int i = 0; i < 10000; i++)
            {
                bool isContinue = false;
                string targetStr = i.ToString().PadLeft(4, '0');
                foreach (var current in targetStr)
                {
                    if (notIncludes.Contains(current.ToString()))
                    {
                        isContinue = true;
                        break;
                    }
                }
                if (isContinue) continue;

                foreach (var current in includes)
                {
                    if (!targetStr.Contains(current))
                    {
                        isContinue = true;
                        break;
                    }
                }
                if (isContinue) continue;
                ret++;
            }

            Console.WriteLine(ret);
        }
    }
}