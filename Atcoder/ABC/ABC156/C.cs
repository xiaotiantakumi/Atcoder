using System;
using CoderCommon;

namespace Atcoder.ABC156
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var r = ReadIntArray();

            double ret = int.MaxValue;

            for (int i = 0; i < 100; i++)
            {
                double tmp = 0;
                foreach (var item in r)
                {
                    tmp += Math.Pow(item - i, 2);
                }

                if (ret > tmp)
                {
                    ret = tmp;
                }
            }

            Console.WriteLine(ret);
        }
    }
}