﻿using System;
using CoderCommon;

namespace Atcoder.ABC146
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string ret = string.Empty;
            foreach (var s in S)
            {
                var index = (chars.IndexOf(s) + N) % 26;
                ret += chars[index];
            }
            Console.WriteLine(ret);
        }
    }
}