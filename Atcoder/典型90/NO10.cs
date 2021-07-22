using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.典型90
{
    public class NO10 : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<int[]> CPs = new List<int[]>();
            Dictionary<int, long> c1 = new Dictionary<int, long>();
            Dictionary<int, long> c2 = new Dictionary<int, long>();
            // Dummy
            c1.Add(0, 0);
            c2.Add(0, 0);
            long c1CurrentSum = 0;
            long c2CurrentSum = 0;
            for (int i = 0; i < N; i++)
            {
                var CP = Console.ReadLine().Split().Select(int.Parse).ToArray();
                // 累積和のディクショナリを生成
                c1CurrentSum += CP[0] == 1 ? CP[1] : 0;
                c2CurrentSum += CP[0] == 2 ? CP[1] : 0;

                c1.Add(i + 1, c1CurrentSum);
                c2.Add(i + 1, c2CurrentSum);
            }
            var query = int.Parse(Console.ReadLine());
            List<string> retList = new List<string>();
            for (int i = 0; i < query; i++)
            {
                var lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var retC1 = c1[lr[1]] - c1[lr[0] - 1];
                var retC2 = c2[lr[1]] - c2[lr[0] - 1];
                retList.Add(retC1 + " " + retC2);
            }

            Console.WriteLine(string.Join("\n", retList.ToArray()));
        }
    }
}