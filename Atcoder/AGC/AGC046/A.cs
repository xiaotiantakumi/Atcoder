using System;

namespace Atcoder.AGC.AGC046
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var X = int.Parse(Console.ReadLine());
            int i = 1;
            while (true)
            {
                if ((X * i) % 360 == 0)
                {
                    Console.WriteLine(i);
                    return;
                }
                i++;
            }
        }
    }
}