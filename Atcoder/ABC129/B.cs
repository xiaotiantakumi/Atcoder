using System;
using System.Linq;

namespace Atcoder.ABC129
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                var s1 = secondLine.Take(i + 1).Sum();
                var s2 = secondLine.Skip(i + 1).Take(N - i + 1).Sum();
                if (Math.Abs(s1 - s2) <= result)
                {
                    result = Math.Abs(s1 - s2);
                }
            }
            Console.WriteLine(result);
        }
    }
}