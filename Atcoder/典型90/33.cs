using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.典型90
{
    public class No33 : AtcoderBase
    {
        public override  void Run()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = HW[0];
            var W = HW[1];
            int[,] map = new int[H, W];
            int onlightCount = 0;
            if (H == 1 || W == 1)
            {
                Console.WriteLine(H * W);
                return;
            }
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    int onLight = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        if (h + i < 0 || h + i >= H) continue;
                        for (int j = -1; j <= 1; j++)
                        {
                            if (w + j < 0 || w + j >= W) continue;
                            if (map[h + i, w + j] == 1) onLight++;
                        }
                    }

                    if (onLight == 0)
                    {
                        map[h, w] = 1;
                        onlightCount++;
                    }
                }
            }

            Console.WriteLine(onlightCount);
        }
    }
}
