using System;
using CoderCommon;

namespace Atcoder.ABC141
{
    public class A : CoderBase
    {
        public override void Run()
        {
            string S = Console.ReadLine();
            switch (S)
            {
                case "Sunny":
                    Console.Write("Cloudy");
                    break;
                case "Cloudy":
                    Console.Write("Rainy");
                    break;
                case "Rainy":
                    Console.Write("Sunny");
                    break;
            }
        }
    }
}