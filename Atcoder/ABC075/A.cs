﻿using System;
using System.Linq;

namespace Atcoder.ABC075
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] == r[1])
            {
                Console.WriteLine(r[2]);
            }
            else if (r[0] == r[2])
            {
                Console.WriteLine(r[1]);
            }
            else
            {
                Console.WriteLine(r[0]);
            }
        }
    }
}