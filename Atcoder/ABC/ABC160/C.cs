using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC160
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var KN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var distance = int.MaxValue;
            for (int i = 0; i < KN[1]; i++)
            {
                if (i == 0)
                {
                    distance = Math.Min(distance, KN[0] - (As[i] - 0));
                    distance = Math.Min(distance, As[KN[1] - 1] - As[0]);
                }
                else if (i == KN[1] - 1)
                {
                    distance = Math.Min(distance, KN[0] - (KN[1] - As[i]));
                    distance = Math.Min(distance, As[KN[1] - 1] - As[0]);
                }
                else
                {
                    distance = Math.Min(distance, KN[0] - (As[i] - As[i - 1]));
                    distance = Math.Min(distance, KN[0] - (As[i + 1] - As[i]));
                }
            }

            Console.WriteLine(distance);
        }
    }
}