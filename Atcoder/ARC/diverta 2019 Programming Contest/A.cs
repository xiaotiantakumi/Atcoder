using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ARC.diverta_2019_Programming_Contest
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NK[0] - NK[1] + 1);
        }
    }
}