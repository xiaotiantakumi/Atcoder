﻿using System;
using CoderCommon;

namespace Atcoder.ABC092
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var D = int.Parse(Console.ReadLine());
            Console.Write(Math.Min(A, B) + Math.Min(C, D));
        }
    }
}