using System;
using System.Collections.Generic;

namespace Atcoder.ABC049
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var HW = ReadIntArray();
            List<string> ret = new List<string>();

            for (int i = 0; i < HW[0]; i++)
            {
                var add = Read();
                ret.Add(add);
                ret.Add(add);
            }

            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
        }
    }
}