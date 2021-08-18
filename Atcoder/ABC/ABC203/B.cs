using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC203
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> rooms = new List<long>();
            long ret = 0;
            for (int i = 0; i < NK[0]; i++)
            {
                for (int j = 0; j < NK[1]; j++)
                {
                    ret += (100 * (i + 1)) + j + 1;
                }
            }

            Console.WriteLine(ret);
        }
    }
}