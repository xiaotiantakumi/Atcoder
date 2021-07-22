using System;
using CoderCommon;

namespace Atcoder.ABC106
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 105; i <= N; i += 2)
            {
                var lim = (int)Math.Ceiling(Math.Sqrt(i));
                int cntDiv = 0;
                for (int j = 1; j <= lim; j++)
                {
                    if (i % j == 0)
                    {
                        if (j == lim)
                        {
                            cntDiv++;
                        }
                        else
                        {
                            cntDiv += 2;
                        }
                    }
                }

                if (cntDiv == 8)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}