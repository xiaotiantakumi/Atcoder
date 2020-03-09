using System;
using System.Linq;

namespace Atcoder.OtherRatedCon.日立製作所_社会システム事業部_プログラミングコンテスト2020
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var ABM = ReadLongArray();
            var As = ReadLongArray();
            var Bs = ReadLongArray();
            long ret = As.Min() + Bs.Min();
            for (int i = 0; i < ABM[2]; i++)
            {
                var xyc = ReadIntArray();
                ret = Math.Min(As[xyc[0] - 1] + Bs[xyc[1] - 1] - xyc[2], ret);
            }

            Console.WriteLine(ret);
        }
    }
}