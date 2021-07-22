﻿using System;
using CoderCommon;

namespace Atcoder.ABC.ABC172
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();
            int ret = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != T[i])
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}