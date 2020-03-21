using System;

namespace Atcoder.ABC158
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var AB = ReadLongArray();
            for (int i = 0; i <= 10000; i++)
            {
                var isA = (int)(i * 0.08) == AB[0];
                var isB = (int)(i * 0.1) == AB[1];
                if (isA && isB)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}