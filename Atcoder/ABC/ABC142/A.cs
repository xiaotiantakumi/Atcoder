﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC142
{
    public class A : CoderBase
    {
        public override void Run()
        {
            double N = double.Parse(Console.ReadLine());
            int oddCount = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    oddCount++;
                }
            }

            double ret = oddCount / N;
            Console.Write(ret);
        }
    }
}