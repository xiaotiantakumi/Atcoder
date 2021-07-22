using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC025
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < NAB[0]; i++)
            {
                var tmp = Console.ReadLine().Split();
                var s = tmp[0];
                var d = int.Parse(tmp[1]);
                d = Math.Min(Math.Max(NAB[1], d), NAB[2]);
                if (s == "West")
                {
                    ret -= d;
                }
                else
                {
                    ret += d;
                }
            }

            if (ret == 0)
            {
                Console.WriteLine(0);
            }
            else if (ret < 0)
            {
                Console.WriteLine("West " + Math.Abs(ret));
            }
            else
            {
                Console.WriteLine("East " + Math.Abs(ret));
            }
        }
    }
}