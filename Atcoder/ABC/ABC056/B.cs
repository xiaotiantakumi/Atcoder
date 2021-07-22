using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ABC056
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var wab = ReadIntArray();
            int cal = 0;
            int ret = 0;
            if (wab[1] < wab[2])
            {
                cal = wab[2] - (wab[0] + wab[1]);
                ret = cal <= 0 ? 0 : cal;
            }
            else
            {
                cal = wab[1] - (wab[0] + wab[2]);
                ret = cal <= 0 ? 0 : cal;
            }

            Console.WriteLine(ret);
        }
    }
}