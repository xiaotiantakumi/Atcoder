using System;

namespace Atcoder.ABC.ABC179
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = long.Parse(Console.ReadLine());
            int ret = 0;
            for (long a = 1; a <= 1000000; a++)
            {
                for (long b = a; b <= 1000000; b++)
                {
                    var c = N - a * b;
                    if (c > 0)
                    {
                        if (a == b)
                        {
                            ret++;
                        }
                        else
                        {
                            ret += 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}