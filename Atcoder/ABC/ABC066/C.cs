﻿using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC066
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (N == 1)
            {
                Console.WriteLine(r[0]);
                return;
            }

            List<int> ret = new List<int>();

            bool flg = false;
            for (int i = 0; i < N; i++)
            {
                if (flg)
                {
                    ret.Add(r[i]);
                }
                else
                {
                    ret.Insert(0, r[i]);
                }
                flg = !flg;
            }
            if (N % 2 != 0)
            {
                Console.WriteLine(string.Join(" ", ret));
            }
            else
            {
                ret.Reverse();
                Console.WriteLine(string.Join(" ", ret));
            }
        }
    }
}