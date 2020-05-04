using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC166
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> own = new HashSet<int>();
            for (int i = 0; i < NK[1]; i++)
            {
                var len = int.Parse(Console.ReadLine());
                var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < len; j++)
                {
                    own.Add(As[j]);
                }
            }

            Console.WriteLine(NK[0] - own.Count);
        }
    }
}