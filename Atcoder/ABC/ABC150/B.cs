﻿using System;
using CoderCommon;

namespace Atcoder.ABC150
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            int ret = 0;
            for (int i = 0; i < N - 2; i++)
            {
                if (S[i] == 'A' && S[i + 1] == 'B' && S[i + 2] == 'C')
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}