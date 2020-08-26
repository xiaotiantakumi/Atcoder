using System;
using System.Linq;

namespace Atcoder.ABC.ABC176
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            long sum = 0;
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i < N; i++)
            {
                var pre = As[i - 1];
                var current = As[i];
                if (pre > current)
                {
                    var dif = pre - current;
                    sum += dif;
                    As[i] += dif;
                }
            }

            Console.WriteLine(sum);
        }
    }
}