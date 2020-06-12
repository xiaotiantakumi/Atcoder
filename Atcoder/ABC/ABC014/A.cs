using System;

namespace Atcoder.ABC.ABC014
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = a % b;
            if (c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(b - c);
            }
        }
    }
}