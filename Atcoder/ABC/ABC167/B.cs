using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC167
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ABCK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABCK[0];
            var B = ABCK[1];
            var C = ABCK[2];
            var K = ABCK[3];
            int ret = 0;

            if (K <= A)
            {
                Console.WriteLine(K);
                return;
            }

            if (K <= A + B)
            {
                Console.WriteLine(A);
                return;
            }

            Console.WriteLine(A - (K - A - B));
        }
    }
}