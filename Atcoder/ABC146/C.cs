using System;
using System.Linq;

namespace Atcoder.ABC146
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var X = input[2];

            long N = 1000000000;
            long ret = long.MinValue;

            int index = 0;
            long minVal = long.MaxValue;
            long maxVal = long.MinValue;
            while (index < 100000)
            {
                var tmp = A * N + B * N.ToString().Length;
                if (X < tmp)
                {
                    if (ret != long.MinValue)
                    {
                        N = N - ((N - ret) / 2);
                    }
                    else
                    {
                        N = N / 2;
                    }
                }
                else
                {
                    if (N >= 1000000000)
                    {
                        N = 1000000000;
                    }
                    if (ret <= N)
                    {
                        ret = N;
                    }
                    N = N + (N / 2);
                    minVal = N;
                }

                index++;
            }

            if (ret == long.MinValue)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(ret);
            }
        }
    }
}