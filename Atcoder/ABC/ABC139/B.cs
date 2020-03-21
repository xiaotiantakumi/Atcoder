using System;
using System.Linq;

namespace Atcoder.ABC139
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            // この問題、ABC101のCに近いような気がする
            // 割り算やって切り上げるという部分
            // http://bttb.s1.valueserver.jp/wordpress/blog/2017/07/23/%E7%AB%B6%E3%83%97%E3%83%AD%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%83%83%E3%82%AF-%E5%89%B2%E3%82%8A%E7%AE%97%E3%81%AE%E5%88%87%E3%82%8A%E4%B8%8A%E3%81%92%E3%80%81%E5%9B%9B%E6%8D%A8%E4%BA%94%E5%85%A5/
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = l[0];
            var B = l[1];
            int ret = 0;
            // 必要な口が一つの場合はプラグが不要というケースが抜けていたからミスってた。
            if (B == 1)
            {
                Console.WriteLine(ret);
                return;
            }
            while (B > 0)
            {
                if (A >= B)
                {
                    B -= A;
                }
                else
                {
                    B -= A - 1;
                }
                ret++;
            }
            Console.WriteLine(ret);
        }
    }
}