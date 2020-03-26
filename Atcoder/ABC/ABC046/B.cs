﻿using System;
using System.Linq;

namespace Atcoder.ABC046
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (NK[0] == 1)
            {
                Console.WriteLine(NK[1]);
            }
            else
            {
                Console.WriteLine(NK[1] * (Math.Pow(NK[1] - 1, NK[0] - 1)));
            }
        }
    }
}