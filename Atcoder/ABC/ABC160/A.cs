﻿using System;
using CoderCommon;

namespace Atcoder.ABC160
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            if (r[2] == r[3] && r[4] == r[5])
            {
                Console.WriteLine("Yes");
                return;
            }

            Console.WriteLine("No");
        }
    }
}