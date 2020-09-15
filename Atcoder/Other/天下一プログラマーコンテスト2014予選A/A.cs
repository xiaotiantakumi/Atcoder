using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.Other.天下一プログラマーコンテスト2014予選A
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            int c = 1000;
            int i = 0;
            List<string> s = Enumerable.Repeat(1, c).Select(x_ => (++i).ToString()).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join("\n", s));
        }
    }
}