using System;
using System.Linq;

namespace Atcoder.ABC.ABC191
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var VTSD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = VTSD[0] * VTSD[1];
            var end = VTSD[0] * VTSD[2];
            var D = VTSD[3];
            if (D < start || D > end)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}