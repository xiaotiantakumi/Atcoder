using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.典型90
{
    public class No55 : CoderBase
    {
        public override  void Run()
        {
            var NPQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NPQ[0];
            var P = NPQ[1];
            int ret = 0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    for (int k = 0; k < j; ++k)
                    {
                        for (int l = 0; l < k; ++l)
                        {
                            for (int m = 0; m < l; ++m)
                            {
                                // 以下部分をdecimalにするとTLEとなる。。
                                if (1L * As[i] * As[j] % P * As[k] % P * As[l] % P * As[m] % P == NPQ[2]) ++ret;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}
