using System;
using System.Collections.Generic;

namespace Atcoder.ABC085
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int> mochis = new List<int>();
            for (int i = 0; i < N; i++)
            {
                mochis.Add(int.Parse(Console.ReadLine()));
            }
            mochis.Sort();
            int ret = 1;
            for (int i = 0; i < mochis.Count - 1; i++)
            {
                if (mochis[i] < mochis[i + 1])
                {
                    ret++;

                }
            }
            Console.WriteLine(ret);
        }
    }
}