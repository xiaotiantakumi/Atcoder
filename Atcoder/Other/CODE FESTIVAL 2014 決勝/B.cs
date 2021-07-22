using System;
using CoderCommon;

namespace Atcoder.Other.CODE_FESTIVAL_2014_決勝
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            int ret = int.Parse(r[0].ToString());
            bool flg = false;
            for (int i = 1; i < r.Length; i++)
            {
                if (flg)
                {
                    ret += int.Parse(r[i].ToString());
                }
                else
                {
                    ret -= int.Parse(r[i].ToString());
                }

                flg = !flg;
            }

            Console.WriteLine(ret);
        }
    }
}