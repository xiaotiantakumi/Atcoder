using System;
using System.Linq;

namespace Atcoder.ABC136
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var ret = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i.ToString().Length % 2 == 1)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}