using System;

namespace Atcoder.ABC138
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            if (a >= 3200)
            {
                Console.WriteLine(s);

            }
            else
            {
                Console.WriteLine("red");
            }
        }
    }
}