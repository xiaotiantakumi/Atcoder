using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC179
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = 0;
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                var inp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (inp[0] == inp[1])
                {
                    ++cnt;
                    ret = Math.Max(ret, cnt);
                }
                else
                {
                    cnt = 0;
                }
            }

            Console.WriteLine(ret >= 3 ? "Yes" : "No");
        }
    }
}