﻿using System;
using System.Linq;

namespace Atcoder.ABC071
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = Math.Abs(r[0] - r[1]);
            var b = Math.Abs(r[0] - r[2]);
            if (a < b)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }
        }
    }
}