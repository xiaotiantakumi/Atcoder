using System;
using System.Collections.Generic;

namespace Atcoder.ABC.ABC173
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            Dictionary<string, int> ret = new Dictionary<string, int>();
            ret["AC"] = 0;
            ret["WA"] = 0;
            ret["TLE"] = 0;
            ret["RE"] = 0;
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine();
                ret[r]++;
            }

            foreach (var item in ret)
            {
                Console.WriteLine(item.Key + " x " + item.Value);
            }
        }
    }
}