using System;

namespace Atcoder.ABC066
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            for (int i = S.Length - 2; i >= 0; i -= 2)
            {
                var halfPos = i / 2;
                if (S.Substring(0, halfPos) == S.Substring(halfPos, halfPos))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}