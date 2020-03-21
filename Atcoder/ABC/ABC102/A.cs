using System;

namespace Atcoder.ABC102
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine(N);
            }
            else
            {
                Console.WriteLine(N * 2);
            }
        }
    }
}