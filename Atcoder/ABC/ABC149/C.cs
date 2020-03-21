using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC149
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            List<int> primes = new List<int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 2; i < int.MaxValue; i++)
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
                    if (i >= N)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(primes.Last());
        }
    }
}