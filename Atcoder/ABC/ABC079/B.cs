using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC079
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Cal(n));
        }

        static Dictionary<int, long> memo = new Dictionary<int, long>();
        static long Cal(int val)
        {
            if (val == 0) return 2;
            if (val == 1) return 1;
            if (!memo.ContainsKey(val))
            {
                memo[val] = Cal(val - 1) + Cal(val - 2);
            }
            return memo[val];
        }
    }
}