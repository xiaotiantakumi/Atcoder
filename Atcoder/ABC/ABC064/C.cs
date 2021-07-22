using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC064
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = 0;
            int max = 0;
            min += r.Any(x => x < 400) ? 1 : 0;
            min += r.Any(x => x >= 400 && x < 800) ? 1 : 0;
            min += r.Any(x => x >= 800 && x < 1200) ? 1 : 0;
            min += r.Any(x => x >= 1200 && x < 1600) ? 1 : 0;
            min += r.Any(x => x >= 1600 && x < 2000) ? 1 : 0;
            min += r.Any(x => x >= 2000 && x < 2400) ? 1 : 0;
            min += r.Any(x => x >= 2400 && x < 2800) ? 1 : 0;
            min += r.Any(x => x >= 2800 && x < 3200) ? 1 : 0;
            max = min;
            var p = r.Count(x => x >= 3200);
            if (min <= 8 && p > 0)
            {
                while (max <= 8 && p > 0)
                {
                    max += 1;
                    p--;
                }
            }

            if (min > max)
            {
                min = max;
            }
            Console.WriteLine(min + " " + max);
        }
    }
}