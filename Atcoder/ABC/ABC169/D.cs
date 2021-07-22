using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC169
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var primes = GetPrimes(N).ToHashSet();
            int ret = 0;
            long current = N;
            for (int i = 2; i <= N; i++)
            {
                if (primes.Contains(N))
                {
                    Console.WriteLine(N);
                    return;
                }
                if (current % i == 0)
                {
                    ret++;
                    current /= i;
                }

                if (current <= i)
                {
                    break;
                }
            }

            Console.WriteLine(ret);
        }

        static IEnumerable<long> GetPrimes(long n)
        {
            while ((n & 1) == 0)
            {
                n >>= 1;
                yield return 2;
            }
            for (long i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    n /= i;
                    yield return i;
                }
            }
            if (n != 1) yield return n;
        }
    }
}