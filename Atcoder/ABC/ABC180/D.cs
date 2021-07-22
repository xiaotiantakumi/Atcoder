using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC180
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var XYAB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = XYAB[0];
            var Y = XYAB[1];
            var A = XYAB[2];
            var B = XYAB[3];
            long cnt = 0;
            long current = 0;
            bool flg = false;
            while (true)
            {
                if (!flg)
                {
                    long tmp1 = X * A;
                    long tmp2 = X + B;
                    if (tmp1 > tmp2)
                    {
                        flg = !flg;
                    }
                    if (Y <= X * A)
                    {
                        break;
                    }
                    X *= A;
                }
                else
                {
                    var tmp = (Y - X) / B;
                    if (tmp > 0)
                    {
                        cnt += tmp - 1;
                    }
                    break;
                }

                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}