﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC067
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var sum = r.Sum();

            long left = 0;
            long ret = long.MaxValue;

            for (long i = 0; i < N - 1; i++)
            {
                left += r[i];
                var right = sum - left;
                if (Math.Abs(left - right) < ret)
                {
                    ret = Math.Abs(left - right);
                }
            }
            Console.WriteLine(ret);
        }
    }
}