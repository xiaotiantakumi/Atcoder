﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC070
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = Math.Min(r[3], r[1]) - Math.Max(r[2], r[0]);
            Console.WriteLine(ret < 0 ? 0 : ret);
        }
    }
}