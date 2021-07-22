using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC072
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = r[0] - r[1];
            if (ret < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(ret);
            }
        }
    }
}