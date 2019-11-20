using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC145
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int> Xs = new List<int>();
            List<int> Ys = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Xs.Add(input[0]);
                Ys.Add(input[1]);
            }

            List<double> distance = new List<double>();
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    var tmp = Math.Sqrt((Xs[i] - Xs[j]) * (Xs[i] - Xs[j]) + (Ys[i] - Ys[j]) * (Ys[i] - Ys[j]));
                    distance.Add(tmp);
                }
            }
            Console.WriteLine(distance.Average());
        }
    }
}