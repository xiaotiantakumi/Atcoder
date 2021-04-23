using System;
using System.Linq;

namespace Atcoder.ABC.ABC191
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var VTSD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var min = VTSD[0] * VTSD[1];
            var max = VTSD[0] * VTSD[2];
            if (min < VTSD[2] && VTSD[2] < max)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}