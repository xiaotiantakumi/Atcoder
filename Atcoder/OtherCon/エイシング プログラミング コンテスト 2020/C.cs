using System;
using System.Collections.Generic;

namespace Atcoder.OtherCon.エイシング_プログラミング_コンテスト_2020
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<double, int> dic = new Dictionary<double, int>();
            for (int x = 1; x <= 100; x++)
            {
                for (int y = 1; y <= 100; y++)
                {
                    for (int z = 1; z <= 100; z++)
                    {
                        var cal = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + x * y + x * z + y * z;
                        if (!dic.ContainsKey(cal))
                        {
                            dic[cal] = 1;
                        }
                        else
                        {
                            dic[cal]++;
                        }
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(dic[i]);
                }
            }
        }
    }
}