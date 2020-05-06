using System;
using System.Linq;

namespace Atcoder.ABC.ABC030
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var nm = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var hourRan = (nm[0] % 12) * 360 / 12 + nm[1] * 360 / 12 / 60;
            var minRan = nm[1] * 360 / 60;
            var ret = Math.Max(hourRan, minRan) - Math.Min(hourRan, minRan);
            Console.WriteLine(ret > 180 ? 360 - ret : ret);
        }
    }
}