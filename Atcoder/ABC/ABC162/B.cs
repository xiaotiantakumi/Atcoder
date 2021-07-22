using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC162
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            LinkedList<long> nums = new LinkedList<long>();
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    continue;
                }

                nums.AddLast(i);
            }

            Console.WriteLine(nums.Sum());  
        }
    }
}