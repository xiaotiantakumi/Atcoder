using System;
using CoderCommon;

namespace Atcoder.ABC138
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            if (a >= 3200)
            {
                Console.WriteLine(s);

            }
            else
            {
                Console.WriteLine("red");
            }
        }
    }
}