using System;
using System.Linq;

namespace Atcoder.ABCLike.MSOLUTIONS_プロコンオープン_2020
{
    public class D : AtcoderBase
    {
        public override void Run()
        {
            bool isBuy = true;
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long remain = 1000;
            long book = 0;
            long current = As[0];
            for (int i = 1; i < N; i++)
            {
                if (isBuy)
                {
                    if (As[i] > current)
                    {
                        book = remain / current;
                        remain -= current * book;
                        isBuy = !isBuy;
                        current = As[i];
                    }
                    else
                    {
                        current = Math.Min(current, As[i]);
                    }

                }
                else
                {
                    if (As[i] < current)
                    {
                        remain += book * current;
                        book = 0;
                        isBuy = !isBuy;
                        current = As[i];
                    }
                    else
                    {
                        current = Math.Max(current, As[i]);
                    }

                }
            }

            if (book != 0)
            {
                remain += book * current;
            }

            Console.WriteLine(remain);
        }
    }
}