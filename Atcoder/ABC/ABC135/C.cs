using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC135
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ret = 0;
            for (int i = 0; i < N; i++)
            {
                if (r1[i] > r2[i])
                {
                    ret += r2[i];
                }
                else
                {
                    ret += r1[i];
                    var remain = r2[i] - r1[i];
                    if (r1[i + 1] <= remain)
                    {
                        ret += r1[i + 1];
                        r1[i + 1] = 0;
                    }
                    else
                    {
                        ret += remain;
                        r1[i + 1] = r1[i + 1] - remain;
                    }
                }
            }
            Console.WriteLine(ret);
        }
    }
}