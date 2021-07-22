using System;
using CoderCommon;

namespace Atcoder.ABC.ABC198
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    if (i + j == n)
                    {
                        ret++;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}