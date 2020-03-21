using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC062
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            var H = r[0];
            var W = r[1];
            List<string> row = new List<string>();
            row.Add(string.Concat(Enumerable.Repeat("#", W + 2).ToArray()));
            for (int i = 0; i < H; i++)
            {
                var line = Read();
                row.Add("#" + line + "#");
            }
            row.Add(string.Concat(Enumerable.Repeat("#", W + 2).ToArray()));
            foreach (var item in row)
            {
                Console.WriteLine(item);
            }
        }
    }
}