﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC133
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long result = long.MaxValue;
            long left = first[0] % 2019;
            long right = first[1] % 2019;
            if (left >= right)
            {
                right = 2019;
            }
            for (long i = left; i < right; i++)
            {
                for (long j = i + 1; j <= right; j++)
                {
                    var tmpCal = (i * j) % 2019;
                    if (result >= tmpCal)
                    {
                        result = tmpCal;
                    }
                }

            }
            Console.Write(result);
        }
    }
}