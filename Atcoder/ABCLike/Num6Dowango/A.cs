using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABCLike.Num6Dowango
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<Tuple<string, int>> tpList = new List<Tuple<string, int>>();
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine().Split().ToArray();
                tpList.Add(new Tuple<string, int>(r[0], int.Parse(r[1])));
            }
            var target = Console.ReadLine();
            var flg = false;
            var ret = 0;
            for (int i = 0; i < N; i++)
            {
                if (!flg && tpList[i].Item1 == target)
                {
                    flg = true;
                    continue;
                }
                else if (flg)
                {
                    ret += tpList[i].Item2;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(ret);
        }
    }
}