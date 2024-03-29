﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC136
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = inputs.Length - 1; i >= 1; i--)
            {
                if (inputs[i - 1] - inputs[i] == 1)
                {
                    inputs[i - 1]--;
                }
                else if (inputs[i - 1] - inputs[i] > 1)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}