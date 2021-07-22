using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOJ.ALDS1._1
{
    class A
    {
        public static void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", A));
            insertionSort(A, N);
        }

        private static void insertionSort(int[] A, int N)
        {
            for (int i = 1; i < N; i++)
            {
                var v = A[i];
                var j = i - 1;
                while (j >= 0 && A[j] > v)
                {
                    A[j + 1] = A[j];
                    j--;
                }

                A[j + 1] = v;
                Console.WriteLine(string.Join(" ", A));
            }
        }
    }
}
