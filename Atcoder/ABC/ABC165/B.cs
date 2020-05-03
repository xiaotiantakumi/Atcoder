using System;

namespace Atcoder.ABC.ABC165
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var X = long.Parse(Console.ReadLine());
            double cal = 100;
            int count = 0;
            while (X > cal)
            {
                cal += Math.Truncate(cal * 0.01);
                count++;
            }

            Console.WriteLine(count);
        }
    }
}