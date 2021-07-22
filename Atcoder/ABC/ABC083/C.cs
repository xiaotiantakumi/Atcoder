using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC083
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int i = 0;
            int ret = 0;
            long tmp = 0;

            while (r[1] >= tmp)
            {
                ret++;
                if (i == 0)
                {
                    tmp = r[0];
                    i++;
                }
                else
                {
                    tmp *= 2;
                    i++;
                }
            }

            if (ret > 0)
            {
                ret--;
            }
            Console.WriteLine(ret);
        }
    }
}