using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC.ABC191
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NX[0];
            var X = NX[1];
            var As = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            foreach (var item in As)
            {
                if (item == X)
                {
                    continue;
                }
                result.Add(item);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}