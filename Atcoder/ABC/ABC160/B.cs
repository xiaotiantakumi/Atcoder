using System;
using CoderCommon;

namespace Atcoder.ABC160
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = int.Parse(Console.ReadLine());
            int ret = 0;
            if (r >= 500)
            {
                ret += r / 500 * 1000;
            }

            var remain = r % 500;
            ret += remain / 5 * 5;
            Console.WriteLine(ret);
        }
    }
}