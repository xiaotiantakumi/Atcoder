using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC137
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            string preStr = string.Empty;
            int ret = 0;
            HashSet<string> strHash = new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().OrderBy(x => x).ToArray();
                var s = new string(tmp);
                if (!strHash.Add(s))
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}