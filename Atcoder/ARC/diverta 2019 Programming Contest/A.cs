using System;
using System.Linq;

namespace Atcoder.ARC.diverta_2019_Programming_Contest
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NK[0] - NK[1] + 1);
        }
    }
}