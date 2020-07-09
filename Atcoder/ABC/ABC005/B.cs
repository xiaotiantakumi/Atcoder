﻿using System;

namespace Atcoder.ABC.ABC005
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                ret = Math.Min(ret, int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(ret);
        }
    }
}