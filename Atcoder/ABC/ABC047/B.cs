using System;
using CoderCommon;

namespace Atcoder.ABC047
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var WHN = ReadIntArray();
            int[] rect = new int[4];
            rect[0] = 0;
            rect[1] = WHN[0];
            rect[2] = 0;
            rect[3] = WHN[1];

            for (int i = 0; i < WHN[2]; i++)
            {
                var xya = ReadIntArray();
                switch (xya[2])
                {
                    case 1:
                        // 最初はすべて読み込んだ値に置き換えていたけど、毎度今の値と比較しないとおかしくなる。
                        rect[0] = Math.Max(xya[0], rect[0]);
                        break;
                    case 2:
                        rect[1] = Math.Min(xya[0], rect[1]);
                        break;
                    case 3:
                        rect[2] = Math.Max(xya[1], rect[2]);
                        break;
                    case 4:
                        rect[3] = Math.Min(xya[1], rect[3]);
                        break;
                }
            }

            // -width * -heightの場合にプラスになって不正な値になってしまう
            var ret = Math.Max(0, (rect[1] - rect[0]) * Math.Max(0, (rect[3] - rect[2])));
            Console.WriteLine(ret);
        }
    }
}