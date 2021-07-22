using System;
using CoderCommon;

namespace Atcoder.ABC049
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var str = "aiueo";
            var c = Read()[0];
            if (str.Contains(c))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
    }
}