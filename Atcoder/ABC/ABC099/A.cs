using System;
using CoderCommon;

namespace Atcoder.ABC099
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N >= 1000)
            {
                Console.WriteLine("ABD");
            }
            else
            {
                Console.WriteLine("ABC");
            }
        }
    }
}