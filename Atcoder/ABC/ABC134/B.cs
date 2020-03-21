using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC134
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = (double)inputs[0];
            var D = (double)inputs[1];

            double ret = N / (2 * D + 1);
            Console.WriteLine(Math.Ceiling(ret));
        }
    }
}