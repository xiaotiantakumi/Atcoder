using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC093
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> ret = new List<int>();
            if (f[1] - f[0] <= f[2])
            {
                for (int i = f[0]; i <= f[1]; i++)
                {
                    Console.WriteLine(i);
                }
                return;
            }
            for (int i = f[0]; i < f[0] + f[2]; i++)
            {
                ret.Add(i);
            }

            for (int i = f[1] - f[2] + 1; i <= f[1]; i++)
            {
                if (!ret.Contains(i))
                {
                    ret.Add(i);
                }
            }

            foreach (var i in ret)
            {
                Console.WriteLine(i);
            }
        }
    }
}