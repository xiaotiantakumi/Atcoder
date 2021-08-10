using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC213
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var HWN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> As = new List<int>();
            List<int> Bs = new List<int>();
            for (int i = 0; i < HWN[2]; i++)
            {
                var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                As.Add(ab[0]);
                Bs.Add(ab[1]);
            }
            var ret1 = CoordinateCompression(As);
            var ret2 = CoordinateCompression(Bs);
            for (int i = 0; i < HWN[2]; i++)
            {
                Console.WriteLine(string.Join(" ", ret1[i] + 1, ret2[i] + 1));
            }
        }
        static private List<int> CoordinateCompression<T>(List<T> raw) where T : struct
        {
            var values = raw.Distinct().OrderBy(x => x).ToList();
            List<int> result = new List<int>();
            foreach (var t in raw)
            {
                var index = values.BinarySearch(t);
                result.Add(values.BinarySearch(t));
            }
            return result;
        }
    }
}