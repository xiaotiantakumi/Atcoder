﻿using System;
using CoderCommon;

namespace Atcoder.ABC.ABC017
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            if (string.IsNullOrEmpty(r.Replace("ch", "").Replace("o", "").Replace("k", "").Replace("u", "")))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}