using System;

namespace Atcoder.ABC076
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var K = int.Parse(Console.ReadLine());
            int ret = 1;
            for (int i = 0; i < N; i++)
            {
                var a = ret * 2;
                var b = ret + K;
                if (a < b)
                {
                    ret = a;
                }
                else
                {
                    ret = b;
                }
            }
            Console.WriteLine(ret);
        }
    }
}