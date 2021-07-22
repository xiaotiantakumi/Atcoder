using System;
using CoderCommon;

namespace Atcoder.Other
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (s.Length != t.Length)
            {
                Console.WriteLine(-1);
                return;
            }

            if (s == t)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                s = s[s.Length - 1] + s.Substring(0, s.Length - 1);
                if (s == t)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}