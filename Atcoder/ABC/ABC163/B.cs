using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC163
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = Console.ReadLine().Split().Select(int.Parse).Sum();
            if (NM[0] - sum < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(NM[0] - sum);
            }
        }
    }
}