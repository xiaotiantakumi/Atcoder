using System;

namespace Atcoder.ABC146
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var S = Console.ReadLine();
            switch (S)
            {
                case "SUN":
                    Console.WriteLine("7");
                    break;
                case "MON":
                    Console.WriteLine("6");
                    break;
                case "TUE":
                    Console.WriteLine("5");
                    break;
                case "WED":
                    Console.WriteLine("4");
                    break;
                case "THU":
                    Console.WriteLine("3");
                    break;
                case "FRI":
                    Console.WriteLine("2");
                    break;
                case "SAT":
                    Console.WriteLine("1");
                    break;
            }
        }
    }
}