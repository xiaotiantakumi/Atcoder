using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.三井住友信託銀行プログラミングコンテスト2019
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(r1[0] == r2[0] ? 0 : 1);
        }
    }
}