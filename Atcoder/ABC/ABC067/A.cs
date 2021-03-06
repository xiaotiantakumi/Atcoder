﻿using System;
using System.Linq;

namespace Atcoder.ABC067
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (r[0] % 3 == 0 ||
                r[1] % 3 == 0 ||
                (r[0] + r[1]) % 3 == 0)
            {
                Console.WriteLine("Possible");
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}