using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.ARC014
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            HashSet<string> records = new HashSet<string>();
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                var w = Console.ReadLine();
                if (records.Any() && (records.Contains(w) || records.Last().Last() != w.First()))
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("LOSE");
                    }
                    else
                    {
                        Console.WriteLine("WIN");
                    }
                    return;
                }

                records.Add(w);
            }
            Console.WriteLine("DRAW");
        }
    }
}