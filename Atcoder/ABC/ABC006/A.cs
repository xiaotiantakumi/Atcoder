using System;

namespace Atcoder.ABC.ABC006
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 3 == 0 ? "YES" : "NO");
        }
    }
}