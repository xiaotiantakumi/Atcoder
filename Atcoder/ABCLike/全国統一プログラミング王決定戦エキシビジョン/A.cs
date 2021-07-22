using System;
using CoderCommon;

namespace Atcoder.ABCLike.全国統一プログラミング王決定戦エキシビジョン
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var H1 = int.Parse(Console.ReadLine());
            var H2 = int.Parse(Console.ReadLine());
            Console.WriteLine(H1 - H2);
        }
    }
}