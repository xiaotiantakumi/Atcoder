using System;
using System.Linq;

namespace Atcoder.ABCLike.ACL_Beginner_Contest
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var ABCD = Console.ReadLine().Split().Select(long.Parse).ToArray();
            if (ABCD[0] <= ABCD[3] && ABCD[2] <= ABCD[1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}