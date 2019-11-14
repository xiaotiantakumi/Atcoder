using System;
using System.Linq;

namespace Atcoder.ABC134
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int[] As = new int[N];
            for (int i = 0; i < N; i++)
            {
                As[i] = int.Parse(Console.ReadLine());
            }
            var sortedAs = As.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < N; i++)
            {
                if (As[i] == sortedAs[0])
                {
                    Console.WriteLine(sortedAs[1]);
                }
                else
                {
                    Console.WriteLine(sortedAs[0]);
                }
            }
        }
    }
}