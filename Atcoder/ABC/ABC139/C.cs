﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC139
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ret = 0;
            int tmp = 0;

            for (int i = 0; i < N - 1; i++)
            {
                if (l[i] >= l[i + 1])
                {
                    tmp++;
                }
                else
                {
                    tmp = 0;
                }

                if (tmp > ret)
                {
                    ret = tmp;
                }
            }
            Console.WriteLine(ret);
        }
    }
}