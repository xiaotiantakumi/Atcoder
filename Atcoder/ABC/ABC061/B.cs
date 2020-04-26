using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC061
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ret = new int[NM[0]];
            for (int i = 0; i < NM[1]; i++)
            {
                var ab = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                ret[ab[0]]++;
                ret[ab[1]]++;
            }

            Console.WriteLine(string.Join("\n", ret));
        }
    }
}