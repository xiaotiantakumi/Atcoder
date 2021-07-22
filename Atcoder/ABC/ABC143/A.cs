using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC143
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var dif = input[0] - input[1] * 2;
            if (dif <= 0)
            {
                Console.Write(0);
            }
            else
            {
                Console.Write(dif);
            }
        }
    }
}