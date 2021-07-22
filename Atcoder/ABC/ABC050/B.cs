using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC050
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var Ts = ReadIntArray();
            var M = ReadInt();
            var sum = Ts.Sum();
            List<int> rets = new List<int>();
            for (int i = 0; i < M; i++)
            {
                var PX = ReadIntArray();
                var ret = sum - Ts[PX[0] - 1] + PX[1];
                rets.Add(ret);
            }

            foreach (var ret in rets)
            {
                Console.WriteLine(ret);
            }
        }
    }
}