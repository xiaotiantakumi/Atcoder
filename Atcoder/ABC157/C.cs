using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC157
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var nm = ReadIntArray();

            IList<int[]> pairs = new List<int[]>();
            for (int i = 0; i < nm[1]; i++)
            {
                var r = ReadIntArray();
                pairs.Add(new int[] { r[0], r[1] });
            }

            for (int i = 0; i < 1000; i++)
            {
                if (i.ToString().Length < nm[0])
                {
                    continue;
                }
                if (pairs.All(item => i.ToString()[item[0] - 1].ToString() == item[1].ToString()))
                {
                    Console.WriteLine(i.ToString());
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}