using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC182
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var items = s.Select(x => int.Parse(x.ToString())).ToArray();
            HashSet<int> hash = new HashSet<int>(items).OrderBy(x => x).ToHashSet();
            var sum = items.Sum();
            var div3 = sum % 3;
            if (div3 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (long.Parse(s) < 100)
            {
                if (long.Parse(s) > 10 && (items[0] % 3 == 0 || items[1] % 3 == 0))
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                foreach (var h in hash)
                {
                    if ((sum - h) % 3 == 0)
                    {
                        Console.WriteLine(1);
                        return;
                    }
                }

                Console.WriteLine(2);
                return;
            }
        }
    }
}