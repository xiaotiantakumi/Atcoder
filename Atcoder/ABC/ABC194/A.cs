using System;
using System.Linq;

namespace Atcoder.ABC.ABC194
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (AB[0] + AB[1] >= 15 && AB[1] >= 8)
            {
                Console.WriteLine(1);
            }
            else if (AB[0] + AB[1] >= 10 && AB[1] >= 3)
            {
                Console.WriteLine(2);
            }
            else if (AB[0] + AB[1] >= 3)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}