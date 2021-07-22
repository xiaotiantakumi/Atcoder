using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.日立製作所_社会システム事業部_プログラミングコンテスト2020
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var s = Read();
            var rep = s.Replace("hi", "");
            if (rep.Any())
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}