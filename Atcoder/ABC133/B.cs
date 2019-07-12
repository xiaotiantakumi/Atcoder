using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC133
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = first[0];
            var D = first[1];

            List<int[]> inputList = new List<int[]>();
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                inputList.Add(tmp);
            }

            int result = 0;

            for (int i = 0; i < N; i++)
            {
                for (int k = i + 1; k < N; k++)
                {
                    double tmpR = 0;
                    for (int j = 0; j < D; j++)
                    {
                        tmpR += Math.Pow(Math.Abs(inputList[i][j] - inputList[k][j]), 2);
                    }
                    tmpR = Math.Sqrt(tmpR);
                    if ((int)tmpR == tmpR)
                    {
                        result++;
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}