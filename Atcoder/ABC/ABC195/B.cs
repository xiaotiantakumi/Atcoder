using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC195
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ABW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABW[0];
            var B = ABW[1];
            var W = ABW[2] * 1000;
            int minCount = int.MaxValue;
            int maxCount = int.MinValue;
            for (int i = 1; i <= W; i++)
            {
                if (A * i <= W && W <= B * i)
                {
                    minCount = Math.Min(minCount, i);
                    maxCount = Math.Max(maxCount, i);
                }
            }

            if (minCount == int.MaxValue)
            {
                Console.WriteLine("UNSATISFIABLE");
                return;
            }
            Console.WriteLine(minCount + " " + maxCount);
        }
    }
}