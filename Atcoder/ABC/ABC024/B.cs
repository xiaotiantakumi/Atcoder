using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC024
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NT = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> As = new List<int>();
            int ret = 0;
            for (int i = 0; i < NT[0]; i++)
            {
                var A = int.Parse(Console.ReadLine());
                As.Add(A);
            }
            for (int i = 0; i < NT[0]; i++)
            {
                if (i == NT[0] - 1)
                {
                    ret += NT[1];
                }
                else
                {
                    ret += Math.Min(NT[1], As[i + 1] - As[i]);
                }
            }

            Console.WriteLine(ret);
        }
    }
}