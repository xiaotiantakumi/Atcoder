using System;
using System.Linq;

namespace Atcoder.ABC137
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ').Select(double.Parse).OrderBy(x => x).ToArray();
            double ret = inputs[0];
            for (int i = 1; i < N; i++)
            {
                ret = (ret + inputs[i]) / 2;
            }
            Console.WriteLine(ret);
        }
    }
}