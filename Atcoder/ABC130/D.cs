using System;
using System.Linq;

namespace Atcoder.ABC130
{
    public class D : IAtcoder
    {
        public void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var N = (int)first[0];
            var K = first[1];
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long sums = 0;
            int ret = 0;
            int index = 0;
            //ここのiが配列の先頭からマイナスしていくためのindex
            for (int i = 0; i < N - 1; i++)
            {
                if (index < N - 1)
                {
                    //配列を合計する部分
                    //足し終わった個所からスタート
                    for (int j = index; j < N; j++)
                    {
                        index = j;
                        sums += second[index];
                        if (sums >= K)
                        {
                            break;
                        }
                    }
                }
                //前から消していく処理をやりたいけど。。
                if (sums >= K)
                {
                    ret += N - index;
                    sums -= second[i];
                    continue;
                }
            }

            Console.Write(ret);
        }
    }
}