using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC164
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            HashSet<string> ret = new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                ret.Add(Console.ReadLine());
            }

            Console.WriteLine(ret.Count());
        }
    }
}