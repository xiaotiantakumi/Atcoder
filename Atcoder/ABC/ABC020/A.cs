﻿using System;
using CoderCommon;

namespace Atcoder.ABC.ABC020
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = int.Parse(Console.ReadLine());
            if (r == 1)
            {
                Console.WriteLine("ABC");
            }
            else
            {
                Console.WriteLine("chokudai");
            }
        }
    }
}