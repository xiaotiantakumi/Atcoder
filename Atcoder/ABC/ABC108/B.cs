using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC108
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = input[0];
            var b = input[1];
            var c = input[2];
            var d = input[3];
            var x = c - a;
            var y = d - b;

            var x3 = c - y;
            var y3 = d + x;
            var x4 = a - y;
            var y4 = b + x;
            Console.WriteLine(string.Join(" ", new int[] { x3, y3, x4, y4 }));
        }
    }
}