using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC214
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ST = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    for (int k = 0; k < 101; k++)
                    {
                        if (i + j + k <= ST[0] &&
                            i * j * k <= ST[1])
                        {
                            ret++;
                        }
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}