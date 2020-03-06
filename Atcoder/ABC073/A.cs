using System;

namespace Atcoder.ABC073
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            foreach (var c in r)
            {
                if (c == '9')
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}