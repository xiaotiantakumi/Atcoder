using System;
using System.Linq;

namespace Atcoder.ABC.ABC182
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            int max = 0;
            int ret = 0;
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 2; i < 1001; i++)
            {
                int cnt = 0;
                foreach (var item in As)
                {
                    if (item % i == 0)
                    {
                        cnt++;
                    }
                }

                max = Math.Max(max, cnt);
                if (cnt == max)
                {
                    ret = i;
                }
            }

            Console.WriteLine(ret);
        }
    }
}