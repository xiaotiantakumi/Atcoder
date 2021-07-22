﻿using System;
using CoderCommon;

namespace Atcoder.ABC101
{
    public class A : CoderBase
    {
        public override void Run()
        {
            int ret = 0;
            var S = Console.ReadLine();
            foreach (var s in S)
            {
                if (s == '+')
                {
                    ret++;
                }
                else
                {
                    ret--;
                }

            }
            Console.WriteLine(ret);
        }
    }
}