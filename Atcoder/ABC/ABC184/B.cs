using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC184
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = Console.ReadLine();
            int ret = NX[1];
            foreach (var c in s)
            {
                if (c == 'o')
                {
                    ret++;
                }
                else
                {
                    if (ret > 0)
                    {
                        ret--;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}