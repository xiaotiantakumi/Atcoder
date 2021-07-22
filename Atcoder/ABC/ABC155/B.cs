using System;
using CoderCommon;

namespace Atcoder.ABC155
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var r = ReadIntArray();
            for (int i = 0; i < N; i++)
            {
                if (r[i] % 2 == 0 &&
                    !(r[i] % 3 == 0 || r[i] % 5 == 0))
                {
                    Console.WriteLine("DENIED");
                    return;
                }
            }

            Console.WriteLine("APPROVED");
        }
    }
}