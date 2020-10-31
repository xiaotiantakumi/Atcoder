using System;
using System.Linq;

namespace Atcoder.ARC.ARC009
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            double ret = 0;
            for (int i = 0; i < N; i++)
            {
                var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ret += AB[0] * AB[1];
            }

            ret *= 1.05;
            Console.WriteLine(Math.Truncate(ret));
        }
    }
}