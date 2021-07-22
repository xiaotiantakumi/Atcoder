using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC193
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                var APX = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (APX[0] < APX[2])
                {
                    ret = Math.Min(ret, APX[1]);
                }
            }

            if (ret == int.MaxValue)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(ret);
            }
        }
    }
}