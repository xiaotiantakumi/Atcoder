﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC086
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if ((r[0] * r[1]) % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}