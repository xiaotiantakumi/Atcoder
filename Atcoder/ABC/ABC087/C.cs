using System;
using System.Linq;

namespace Atcoder.ABC087
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ret = 0;
            for (int i = 1; i <= N; i++)
            {
                var sum = r1.Take(i).Sum() + r2.Skip(i - 1).Take(N - i + 1).Sum();
                if (ret < sum)
                {
                    ret = sum;
                }
            }
            Console.WriteLine(ret);
        }
    }
}