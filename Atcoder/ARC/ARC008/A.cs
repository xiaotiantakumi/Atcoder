using System;
using CoderCommon;

namespace Atcoder.ARC.ARC008
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var ten = n / 10;
            var one = n % 10;
            if (one > 6)
            {
                ++ten;
                Console.WriteLine(ten * 100);
            }
            else
            {
                Console.WriteLine(ten * 100 + one * 15);
            }
        }
    }
}