﻿using System;
using System.Linq;

namespace Atcoder.ABC.ABC182
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var limit = 2 * AB[0] + 100;
            Console.WriteLine(limit - AB[1]);
        }
    }
}