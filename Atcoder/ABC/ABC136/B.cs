using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC136
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var ret = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i.ToString().Length % 2 == 1)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}