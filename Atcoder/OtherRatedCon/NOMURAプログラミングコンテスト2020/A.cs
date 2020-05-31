﻿using System;
using System.Linq;

namespace Atcoder.OtherRatedCon.NOMURAプログラミングコンテスト2020
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var HMHMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var hour = (HMHMK[2] - HMHMK[0]) * 60;
            var min = HMHMK[3] - HMHMK[1];
            var sum = hour + min;
            var K = HMHMK[4];
            if (sum >= K)
            {
                Console.WriteLine(sum - K);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}