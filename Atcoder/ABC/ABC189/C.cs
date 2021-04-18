using System;
using System.Linq;

namespace Atcoder.ABC.ABC189
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            int ret = 0;
            var N = int.Parse(Console.ReadLine());
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int l = 0; l < N; l++)
            {
                var min = As[l];
                for (int r = l; r < N; r++)
                {
                    if (As[r] < min)
                    {
                        min = As[r];
                    }

                    var sum = (r - l + 1) * min;
                    if (sum > ret)
                    {
                        ret = sum;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}