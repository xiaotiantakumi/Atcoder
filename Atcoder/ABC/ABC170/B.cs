using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC170
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i <= XY[0]; i++)
            {
                var twoLeg = i;
                var fourLeg = XY[0] - i;
                if (twoLeg * 2 + fourLeg * 4 == XY[1])
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}