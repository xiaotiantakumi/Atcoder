using System;
using System.Linq;

namespace Atcoder.ARC.ARC006
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var Es = Console.ReadLine().Split().Select(int.Parse).ToList();
            var V = int.Parse(Console.ReadLine());
            var Buy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int c = 0;
            for (int i = 0; i < Buy.Length; i++)
            {
                if (Es.Contains(Buy[i]))
                {
                    c++;
                }
            }

            switch (c)
            {
                case 3:
                    Console.WriteLine(5);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                case 5:
                    if (Buy.Contains(V))
                    {
                        Console.WriteLine(2);
                    }
                    else
                    {
                        Console.WriteLine(3);
                    }
                    break;
                case 6:
                    Console.WriteLine(1);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }
        }
    }
}