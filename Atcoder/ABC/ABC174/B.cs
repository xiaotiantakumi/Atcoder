using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC174
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ND = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = ND[0];
            var D = ND[1];
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                var XY = Console.ReadLine().Split().Select(double.Parse).ToArray();
                var dis = Math.Sqrt(Math.Pow(XY[0], 2) + Math.Pow(XY[1], 2));
                if (dis <= D)
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}