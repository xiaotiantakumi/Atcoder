using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ARC.ARC005
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            HashSet<string> items = new HashSet<string>()
            {
                "TAKAHASHIKUN",
                "Takahashikun",
                "takahashikun",
            };
            var N = int.Parse(Console.ReadLine());
            var r = Console.ReadLine().Split().ToArray();
            int ret = 0;
            foreach (var target in r)
            {
                var target2 = target.Replace(".", "");
                if (items.Contains(target2))
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}