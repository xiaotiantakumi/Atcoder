using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC024
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABCK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ST = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (ST.Sum() >= ABCK[3])
            {
                ABCK[0] -= ABCK[2];
                ABCK[1] -= ABCK[2];
            }

            Console.WriteLine(ABCK[0] * ST[0] + ABCK[1] * ST[1]);
        }
    }
}