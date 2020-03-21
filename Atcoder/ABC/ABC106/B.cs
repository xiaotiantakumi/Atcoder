using System;

namespace Atcoder.ABC106
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N == 105)
            {
                Console.WriteLine(1);
                return;
            }
            else if (N < 105)
            {
                Console.WriteLine(0);
                return;
            }

            int ret = 1;
            for (int i = 106; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                int tmpRet = 0;
                for (int j = 1; j <= N; j++)
                {
                    if (i % j == 0)
                    {
                        tmpRet++;
                    }
                }

                if (tmpRet == 8)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}