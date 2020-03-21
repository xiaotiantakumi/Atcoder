using System;

namespace Atcoder.ABC087
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 0; i <= A; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    for (int k = 0; k <= C; k++)
                    {
                        if (500 * i + 100 * j + 50 * k == X)
                        {
                            ret++;
                        }
                    }
                }
            }
            Console.WriteLine(ret);
        }
    }
}