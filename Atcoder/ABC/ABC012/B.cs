using System;
using CoderCommon;

namespace Atcoder.ABC.ABC012
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            TimeSpan ts = new TimeSpan(0, 0, N);
            Console.WriteLine(ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00"));

        }
    }
}