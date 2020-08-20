using System;

namespace Atcoder.ABCLike.MSOLUTIONS_プロコンオープン_2020
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var X = int.Parse(Console.ReadLine());
            if (X < 600)
            {
                Console.WriteLine(8);
            }
            else if (X < 800)
            {
                Console.WriteLine(7);
            }
            else if (X < 1000)
            {
                Console.WriteLine(6);
            }
            else if (X < 1200)
            {
                Console.WriteLine(5);
            }
            else if (X < 1400)
            {
                Console.WriteLine(4);
            }
            else if (X < 1600)
            {
                Console.WriteLine(3);
            }
            else if (X < 1800)
            {
                Console.WriteLine(2);
            }
            else if (X < 2000)
            {
                Console.WriteLine(1);
            }
        }
    }
}