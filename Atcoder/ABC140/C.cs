using System;
using System.Linq;

namespace Atcoder.ABC140
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ret = r[0];
            for (int i = 0; i < N - 1; i++)
            {
                if (i == N - 2)
                {
                    ret += r[i];
                }
                else
                {
                    ret += Math.Min(r[i], r[i + 1]);
                }
            }
            Console.WriteLine(ret);
        }
    }
}