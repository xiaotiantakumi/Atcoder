using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC147
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (l[0] + l[1] + l[2] >= 22)
            {
                Console.WriteLine("bust");
            }
            else
            {
                Console.WriteLine("win");
            }
        }
    }
}