﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC137
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long ret = 0;
            Dictionary<string, long> strHash = new Dictionary<string, long>();
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().OrderBy(x => x).ToArray();
                var s = new string(tmp);
                if (!strHash.ContainsKey(s))
                {
                    strHash.Add(s, 0);
                }
                else
                {
                    strHash[s]++;
                }

                ret += strHash[s];
            }

            Console.WriteLine(ret);
        }
    }
}