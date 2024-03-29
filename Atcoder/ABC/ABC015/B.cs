﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC015
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).Where(x => x != 0).ToArray();
            Console.WriteLine(Math.Ceiling(As.Average()));
        }
    }
}