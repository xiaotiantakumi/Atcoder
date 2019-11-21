using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atcoder.ABC104
{
    public class B : IAtcoder
    {
        public void Run()
        {
            var S = Console.ReadLine();

            // 条件を順番に潰していく。
            // WAの条件に引っかかった時点で出力し、最後まで残ったものがACになる。

            // Aから始まるか判定
            if (!S.StartsWith("A"))
            {
                Console.WriteLine("WA");
                return;
            }

            // 3文字目と末尾から2文字目の間にCがあるか判定
            var tmp = S.Substring(2, S.Length - 3);
            if (tmp.Where(x => x == 'C').ToList().Count != 1)
            {
                Console.WriteLine("WA");
                return;
            }

            // 3文字目と末尾から2文字目に存在する大文字Cの位置を求める
            var cindex = tmp.IndexOf('C') + 2;

            // AとCを消す
            S = S.Remove(cindex, 1).Remove(0, 1);

            // AとCを消した後の文字列に大文字が含まれるか判定
            foreach (var item in S)
            {
                if (char.IsUpper(item))
                {
                    Console.WriteLine("WA");
                    return;
                }
            }

            Console.WriteLine("AC");
        }
    }
}