using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.HHKB_プログラミングコンテスト_2020
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> area = new List<string>();
            for (int i = 0; i < HW[0]; i++)
            {
                var r = Console.ReadLine();
                area.Add(r);
            }

            int ret = 0;
            for (int i = 0; i < HW[0]; i++)
            {
                for (int j = 0; j < HW[1]; j++)
                {
                    var currentPos = area[i][j];
                    if (currentPos == '#')
                    {
                        continue;
                    }
                    if (i != HW[0] - 1 && area[i + 1][j] == '.')
                    {
                        ret++;
                    }

                    if (j != HW[1] - 1 && area[i][j + 1] == '.')
                    {
                        ret++;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }
}