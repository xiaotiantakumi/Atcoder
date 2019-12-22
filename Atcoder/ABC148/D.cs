using System;
using System.Linq;

namespace Atcoder.ABC148
{
    public class D : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            int point = 1;
            for (int i = 0; i < N; i++)
            {
                if (r[i] == point)
                {
                    point++;
                }
                else
                {
                    ret++;
                }
            }

            if (ret == N)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(ret);
            }
        }
    }
}