using System;
using System.Linq;

namespace Atcoder.ABC081
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            bool flg = true;
            while (flg)
            {
                for (int i = 0; i < N; i++)
                {
                    if (r[i] % 2 != 0)
                    {
                        flg = false;
                        break;
                    }
                    r[i] = r[i] / 2;
                }

                if (flg)
                {
                    ret++;
                }
            }
            Console.WriteLine(ret);
        }
    }
}