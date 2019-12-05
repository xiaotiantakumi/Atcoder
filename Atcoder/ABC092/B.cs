using System;
using System.Linq;

namespace Atcoder.ABC092
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var D = f[0];
            var ret = f[1];

            for (int i = 0; i < N; i++)
            {
                var tmp = int.Parse(Console.ReadLine());
                int val = tmp + 1;
                int choco = 1;
                while (val <= D)
                {
                    choco++;
                    val = (choco * tmp) + 1;
                }
                ret += choco;
            }
            Console.WriteLine(ret);
        }
    }
}