﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.エイシング_プログラミング_コンテスト_2020
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = LRd[0]; i <= LRd[1]; i++)
            {
                if (i % LRd[2] == 0)
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}