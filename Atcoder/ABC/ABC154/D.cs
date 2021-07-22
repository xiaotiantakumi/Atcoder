using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC154
{
    public class D : CoderBase
    {
        public override void Run()
        {
            // やりたいこと
            // 区間最大値を求める
            // その区間内の期待値の合計を求める。

            // 区間最大値がうまくもとまってない？？
            var NK = ReadIntArray();
            var ps = ReadIntArray();

            var len = NK[0] - NK[1];
            var posFrom = 0;
            int maxValue = ps.Skip(0).Take(NK[1]).Sum();
            for (int i = 0; i <= len; i++)
            {
                int tmp;
                if (i == 0)
                {
                    tmp = maxValue - ps[i] + ps[len + i];
                }
                else
                {
                    tmp = ps.Skip(i).Take(NK[1]).Sum();
                }
                if (maxValue < tmp)
                {
                    posFrom = i;
                }
            }
            double kitai = 0;
            for (int i = posFrom; i < posFrom + NK[1]; i++)
            {
                double p = ps[i];
                kitai += SumAll(p) / p;
            }

            Console.WriteLine(kitai);
        }

        private static double SumAll(double p)
        {
            if (p == 0)
            {
                return 0;
            }
            return p + SumAll(p - 1);
        }
    }
}