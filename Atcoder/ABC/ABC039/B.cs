﻿using System;
using CoderCommon;

namespace Atcoder.ABC.ABC039
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = long.Parse(Console.ReadLine());
            var ret = Math.Sqrt(Math.Sqrt(r));
            Console.WriteLine(ret);
        }
    }
}