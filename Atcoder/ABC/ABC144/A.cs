﻿using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC144
{
    public class A : CoderBase
    {
        public override void Run()
        {
                        var tmp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (var val in tmp)
            {
                if (val >= 10)
                {
                    Console.Write("-1");
                    return;
                }
            }

            var result = tmp[0] * tmp[1];
            Console.Write(result);
        }
    }
}