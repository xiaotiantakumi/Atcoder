﻿using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC131
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = first[0];
            List<int> tmpList = new List<int>();
            var L = first[1];
            for (int i = 0; i < N; i++)
            {
                tmpList.Add(L + i);
            }
            var except = tmpList.Select(x => Math.Abs(x)).Min();
            int result = 0;
            foreach (var item in tmpList)
            {
                if (item == except || item == -except)
                {
                    continue;
                }
                result += item;
            }
            Console.Write(result);
        }
    }
}