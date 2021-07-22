using System;
using CoderCommon;

namespace Atcoder.ABC054
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var AB = ReadIntArray();
            if (AB[0] == AB[1])
            {
                Console.WriteLine("Draw");
            }
            else if (AB[0] == 1 || (AB[0] > AB[1] && AB[1] != 1))
            {
                Console.WriteLine("Alice");
            }
            else
            {
                Console.WriteLine("Bob");
            }
        }
    }
}