﻿using System;
using CoderCommon;

namespace Atcoder.ABC078
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split();
            if (r[0].CompareTo(r[1]) == 0)
            {
                Console.WriteLine("=");
            }
            else if (r[0].CompareTo(r[1]) < 0)
            {
                Console.WriteLine("<");

            }
            else
            {
                Console.WriteLine(">");

            }
        }
    }
}