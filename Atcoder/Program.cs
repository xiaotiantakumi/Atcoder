using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Atcoder
{

    class Program
    {
        private const long COMDIV = 1000000007;

        static void Main(string[] args)
        {
            var mnN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var m = mnN[0];
            var n = mnN[1];
            var N = mnN[2];
            long ret = 0;
            long remain = 0;
            while (true)
            {
                ret += N;
                N += remain;
                var make = N / m;
                remain += N % m;
                N = make * n;
                if (N < m + remain)
                {
                    ret += N;
                    break;
                }
            }

            Console.WriteLine(ret);
        }

    }
}