using System;

namespace Atcoder.ABC.ABC034
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n - 1);
            }
            else
            {
                Console.WriteLine(n + 1);
            }
        }
    }
}