﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC152
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            int min = N + 1;
            for (int i = 0; i < N; i++)
            {
                if (r[i] < min)
                {
                    ret++;
                    min = r[i];
                }
            }
            Console.WriteLine(ret);
        }
    }
}