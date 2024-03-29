﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC141
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = firstLine[0];
            var K = firstLine[1];
            var Q = firstLine[2];

            long[] Points = new long[N];
            for (int i = 0; i < N; i++)
            {
                Points[i] = 0;
            }

            for (int i = 0; i < Q; i++)
            {
                var target = int.Parse(Console.ReadLine());
                Points[target - 1]++;
            }

            for (int i = 0; i < N; i++)
            {
                if (K - Q + Points[i] > 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}