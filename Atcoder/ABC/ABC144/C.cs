using System;

namespace Atcoder.ABC144
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            var len = (long)Math.Ceiling(Math.Sqrt(N));
            long dis = long.MaxValue;
            for (int i = 1; i <= len; i++)
            {
                if (N % i == 0)
                {
                    long j = N / i;
                    dis = Math.Min(dis, i + j - 2);
                }
            }

            Console.WriteLine(dis);
        }
    }
}