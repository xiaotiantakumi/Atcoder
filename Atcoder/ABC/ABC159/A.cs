using System;
using System.Linq;

namespace Atcoder.ABC159
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NM[0] * (NM[0] - 1) / 2 + NM[1] * (NM[1] - 1) / 2);
        }
    }
}