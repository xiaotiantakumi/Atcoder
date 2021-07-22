using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC151
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var last = r1[2] * r1[0] - (r2.Sum());
            if (last <= 0)
            {
                Console.WriteLine("0");
            }
            else if (last > r1[1])
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(last);
            }
        }
    }
}