﻿using System;
using CoderCommon;

namespace Atcoder.ABC080
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int val = 0;
            foreach (var c in N.ToString())
            {
                val += int.Parse(c.ToString());
            }

            if (N % val == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}