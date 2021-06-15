using System;
using System.Linq;

namespace Atcoder.ABC.ABC199
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            // まだ途中。解けてない。
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            var left = S.Substring(0, N).ToCharArray();
            var right = S.Substring(N, N).ToCharArray();
            var Q = int.Parse(Console.ReadLine());
            var ret = string.Empty;
            bool swapFlg = false;
            for (int i = 0; i < Q; i++)
            {
                var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (r[0] == 1)
                {
                    var a = r[1] - 1;
                    var b = r[2] - N - 1;
                    if (swapFlg)
                    {
                        var tmp = right[a];
                        right[a] = left[b];
                        left[b] = tmp;
                    }
                    else
                    {
                        var tmp = left[a];
                        left[a] = right[b];
                        right[b] = tmp;
                    }
                }
                else
                {
                    swapFlg = !swapFlg;
                }
            }

            if (swapFlg)
            {
                ret = new string(right) + new string(left);
            }
            else
            {
                ret = new string(left) + new string(right);
            }
            Console.WriteLine(ret);
        }
    }
}