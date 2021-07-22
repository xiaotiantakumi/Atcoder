using System;
using CoderCommon;

namespace Atcoder.ABC088
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var A = int.Parse(Console.ReadLine());
            var remain = N % 500;
            if (remain <= A)
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