﻿using System;
using CoderCommon;

namespace Atcoder.ABC077
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var tmp = Math.Sqrt(N);
            var val = Math.Truncate(tmp);
            Console.WriteLine(val * val);
        }
    }
}