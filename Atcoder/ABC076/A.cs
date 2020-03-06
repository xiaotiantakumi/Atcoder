using System;

namespace Atcoder.ABC076
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var R = int.Parse(Console.ReadLine());
            var G = int.Parse(Console.ReadLine());
            Console.WriteLine(2 * G - R);
        }
    }
}