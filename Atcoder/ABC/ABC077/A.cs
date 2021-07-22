using System;
using CoderCommon;

namespace Atcoder.ABC077
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r1 = Console.ReadLine();
            var r2 = Console.ReadLine();
            if (r1[0] == r2[2] && r1[1] == r2[1] && r1[2] == r2[0])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}