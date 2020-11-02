using System;
using System.Linq;

namespace Atcoder.ABC.ABC181
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long ret = 0;
            for (int i = 0; i < N; i++)
            {
                var ab = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var all = ab[1] * (ab[1] + 1) / 2;
                var except = (ab[0] - 1) * ab[0] / 2;
                ret += (all - except);
            }

            Console.WriteLine(ret);
        }
    }
}