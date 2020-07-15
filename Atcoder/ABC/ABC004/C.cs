using System;
using System.Collections.Generic;

namespace Atcoder.ABC.ABC004
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            List<int> ret = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<string> retList = new List<string>();
            retList.Add("123456");
            for (int i = 0; i < 29; i++)
            {
                var c = i % 5;
                int tmp = ret[c];
                ret[c] = ret[c + 1];
                ret[c + 1] = tmp;
                retList.Add(string.Join("", ret));
            }

            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(retList[N % 30]);
        }
    }
}