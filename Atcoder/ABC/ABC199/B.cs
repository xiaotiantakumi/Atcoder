﻿using System;
using System.Linq;

namespace Atcoder.ABC.ABC199
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = B.Min() - A.Max() + 1;
            Console.WriteLine(ret < 0 ? 0 : ret);
        }
    }
}