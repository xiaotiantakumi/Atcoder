using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC212
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (AB[0] == 0 && AB[1] > 0)
            {
                Console.WriteLine("Silver");
            }
            else if (AB[1] == 0 && AB[0] > 0)
            {
                Console.WriteLine("Gold");

            }
            else
            {
                Console.WriteLine("Alloy ");
            }
        }
    }
}