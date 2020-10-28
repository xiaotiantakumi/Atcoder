using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ARC.ARC003
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine();
                dic[new string(r.Reverse().ToArray())] = r;
            }

            foreach (var retPair in dic.OrderBy(x => x.Key))
            {
                Console.WriteLine(retPair.Value);
            }
        }
    }
}