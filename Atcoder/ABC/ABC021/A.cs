using System;

namespace Atcoder.ABC.ABC021
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine(N / 2);

            }
            else
            {
                Console.WriteLine(N / 2 + 1);
                Console.WriteLine(1);
            }
            for (int i = 0; i < N / 2; i++)
            {
                Console.WriteLine(2);
            }
        }
    }
}