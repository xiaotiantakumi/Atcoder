using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC030
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABCD = Console.ReadLine().Split().Select(double.Parse).ToArray();
            if (ABCD[1] / ABCD[0] < ABCD[3] / ABCD[2])
            {
                Console.WriteLine("AOKI");
            }
            else if (ABCD[1] / ABCD[0] == ABCD[3] / ABCD[2])
            {
                Console.WriteLine("DRAW");
            }
            else
            {
                Console.WriteLine("TAKAHASHI");
            }
        }
    }
}