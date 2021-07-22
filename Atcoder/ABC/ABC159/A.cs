using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC159
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NM[0] * (NM[0] - 1) / 2 + NM[1] * (NM[1] - 1) / 2);
        }
    }
}