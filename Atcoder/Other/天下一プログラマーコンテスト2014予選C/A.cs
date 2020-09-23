using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.Other.天下一プログラマーコンテスト2014予選C
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 2)
            {
                Console.WriteLine(0);
                return;
            }
            List<int> primes = new List<int>() { 2 };
            for (int i = 3; i < n; i++)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(primes.Count);
        }
    }
}