﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC184
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ab[0] * cd[1] - ab[1] * cd[0]);
        }
    }
}