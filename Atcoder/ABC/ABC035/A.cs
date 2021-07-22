using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC035
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var WH = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var W = WH[0];
            var H = WH[1];

            if (W % 16 == 0 && H % 9 == 0)
            {
                Console.WriteLine("16:9");
            }
            else
            {
                Console.WriteLine("4:3");
            }
        }
    }
}