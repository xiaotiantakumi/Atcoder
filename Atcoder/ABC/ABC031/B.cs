using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC031
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var LH = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var L = LH[0];
            var H = LH[1];
            var N = int.Parse(Console.ReadLine());
            List<int> ret = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var r = int.Parse(Console.ReadLine());
                if (r < L)
                {
                    ret.Add(L - r);
                }
                else if (r > H)
                {
                    ret.Add(-1);
                }
                else
                {
                    ret.Add(0);
                }
            }

            Console.WriteLine(string.Join("\n", ret));
        }
    }
}