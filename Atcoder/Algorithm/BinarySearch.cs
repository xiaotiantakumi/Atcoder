using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoderCommon;

namespace Atcoder.Algorithm
{
    // ABC146のC
    class BinarySearch : CoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long A = f[0];
            long B = f[1];
            long X = f[2];

            long price = 0;
            long min = 0;
            long mid = 0;
            long max = 1000000001;

            while (max - min > 1)
            {
                mid = (min + max) / 2;
                price = A * mid + B * (mid.ToString().Length);
                if (price <= X)
                    min = mid;
                else
                    max = mid;
            }

            Console.WriteLine(min);
        }
    }
}
