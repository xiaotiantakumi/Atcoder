using System;
using System.Linq;

namespace Atcoder.ARC.diverta_2019_Programming_Contest
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var RGBN = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var R = RGBN[0];
            var G = RGBN[1];
            var B = RGBN[2];
            var N = RGBN[3];

            int ret = 0;
            for (double r = 0; r <= 3000; r++)
            {
                for (double g = 0; g <= 3000; g++)
                {
                    var b = (N - r * R - g * G) / B;
                    var tran = b - Math.Truncate(b);
                    if (b < 0)
                    {
                        break;
                    }
                    if (tran == 0)
                    {
                        ret++;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}