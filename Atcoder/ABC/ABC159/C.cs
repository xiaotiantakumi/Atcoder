using System;
using CoderCommon;

namespace Atcoder.ABC159
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var L = double.Parse(Console.ReadLine());
            double r = L / 3;
            Console.WriteLine(Math.Pow(r, 3));
        }
    }
}