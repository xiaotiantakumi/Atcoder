using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC032
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var k = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i <= s.Length - k; i++)
            {
                var tmp = s.Substring(i, k);
                set.Add(tmp);
            }

            Console.WriteLine(set.Count());
        }
    }
}