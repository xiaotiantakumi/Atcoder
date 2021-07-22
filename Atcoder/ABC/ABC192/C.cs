using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC192
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NK[0];
            for (int i = 1; i <= NK[1]; i++)
            {
                var strN = N.ToString();
                var left = int.Parse(new string(strN.OrderByDescending(x => x).ToArray()));
                var right = int.Parse(new string(strN.Replace("0", "").OrderBy(x => x).ToArray()));
                N = left - right;
                if (N == 0)
                {
                    break;
                }
            }

            Console.WriteLine(N);
        }
    }
}