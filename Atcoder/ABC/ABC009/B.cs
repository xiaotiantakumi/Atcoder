using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC009
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int> prices = new List<int>();
            for (int i = 0; i < N; i++)
            {
                prices.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(prices.OrderByDescending(x => x).Distinct().Skip(1).First());
        }
    }
}