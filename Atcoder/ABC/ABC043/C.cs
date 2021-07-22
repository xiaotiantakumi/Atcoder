using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC043
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double cost = int.MaxValue;

            for (int i = -100; i <= 100; i++)
            {
                double tmpCost = 0;
                foreach (var item in As)
                {
                    tmpCost += Math.Pow((item - i), 2);
                }
                cost = Math.Min(cost, tmpCost);
            }

            Console.WriteLine(cost);
        }
    }
}