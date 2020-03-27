using System;

namespace Atcoder.ABC045
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var ret = (a + b) * n / 2;
            Console.WriteLine(ret);
        }
    }
}