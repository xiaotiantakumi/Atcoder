using System;

namespace Atcoder.ARC.ARC014
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Blue" : "Red");
        }
    }
}