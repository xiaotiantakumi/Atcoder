using System;
using System.Linq;

namespace Atcoder.ABC094
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string ret = "NO";
            if (f[0] + f[1] >= f[2] && f[0] <= f[2])
            {
                ret = "YES";
            }
            Console.WriteLine(ret);
        }
    }
}