using System;
using System.Linq;

namespace Atcoder.ABC073
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = r[0]; j <= r[1]; j++)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}