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
            long left;
            long right;
            if (memo.ContainsKey(val - 1))
            {
                left = memo[val - 1];
            }
            else
            {
                left = Cal(val - 1);
                memo.Add(val - 1, left);
            }
            if (memo.ContainsKey(val - 2))
            {
                right = memo[val - 2];
            }
            else
            {
                right = Cal(val - 2);
                memo.Add(val - 2, right);
            }
            return left + right;
        }
    }
}