using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.PAST._1
{
    public class D : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var array = Enumerable.Repeat(0, N).Select(_ => int.Parse(Console.ReadLine())).OrderBy(o => o).ToList();
            Dictionary<int?, int?> result = new Dictionary<int?, int?>();
            for (int i = 0; i < N; i++)
            {
                result[i] = 0;
            }
            for (int i = 0; i < N; i++)
            {
                result[array[i] - 1]++;
            }

            var X = result.Where(x => x.Value == 0).FirstOrDefault();
            var Y = result.Where(x => x.Value == 2).FirstOrDefault();
            if (X.Key == null)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine((Y.Key + 1) + " " + (X.Key + 1));
            }
        }
    }
}