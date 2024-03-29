﻿using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC132
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var ps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ret = 0;
            for (int i = 0; i < ps.Length - 2; i++)
            {
                if (ps[i] < ps[i + 1] && ps[i + 1] < ps[i + 2] ||
                    ps[i] > ps[i + 1] && ps[i + 1] > ps[i + 2])
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}