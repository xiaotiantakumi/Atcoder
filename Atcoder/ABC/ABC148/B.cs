using System;
using CoderCommon;

namespace Atcoder.ABC148
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                Console.Write(r[0][i].ToString() + r[1][i].ToString());
            }
        }
    }
}