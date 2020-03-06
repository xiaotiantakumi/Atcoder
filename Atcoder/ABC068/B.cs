using System;

namespace Atcoder.ABC068
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            int ret = 0;
            int maxDivide = 0;
            for (int i = 1; i <= N; i++)
            {
                int divideVal = i;
                int divideCount = 0;
                while (divideVal % 2 == 0)
                {
                    divideVal /= 2;
                    divideCount++;
                }

                if (divideCount >= maxDivide)
                {
                    maxDivide = divideCount;
                    ret = i;
                }
            }
            Console.WriteLine(ret);
        }
    }
}