﻿using System;
using CoderCommon;

namespace Atcoder.ABC058
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            if (r[1] - r[0] == r[2] - r[1])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}