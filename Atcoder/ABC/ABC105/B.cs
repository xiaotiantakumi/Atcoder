using System;
using CoderCommon;

namespace Atcoder.ABC105
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N / 7; i++)
            {
                for (int j = 0; j <= N / 4; j++)
                {
                    if (N == (7 * i) + (4 * j))
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}