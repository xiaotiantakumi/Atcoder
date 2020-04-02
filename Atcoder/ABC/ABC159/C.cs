using System;

namespace Atcoder.ABC159
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var L = double.Parse(Console.ReadLine());
            double r = L / 3;
            Console.WriteLine(Math.Pow(r, 3));
        }
    }
}