﻿using System;

namespace Atcoder.ABC064
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = int.Parse(Console.ReadLine().Replace(" ", string.Empty));
            if (r % 4 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}