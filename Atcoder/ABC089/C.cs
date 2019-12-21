using System;

namespace Atcoder.ABC089
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = long.Parse(Console.ReadLine());
            string m = "MARCH";
            long[] counter = new long[5];
            long ret = 0;
            for (long i = 0; i < N; i++)
            {
                var firstChar = Console.ReadLine()[0];
                for (int j = 0; j < 5; j++)
                {
                    if (m[j] == firstChar)
                    {
                        counter[j]++;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        ret += counter[i] * counter[j] * counter[k];
                    }
                }
            }
            Console.WriteLine(ret);
        }
    }
}