using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC138
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double ret = 0;
            for (int i = 0; i < N; i++)
            {
                ret += (1 / inputs[i]);
            }
            Console.WriteLine(1 / ret);
        }
    }
}