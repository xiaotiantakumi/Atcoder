using System;
using System.Linq;

namespace Atcoder.ABC.ABC016
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = r[0];
            var B = r[1];
            var C = r[2];
            var ptn1 = A + B == C;
            var ptn2 = A - B == C;

            if (ptn1 && ptn2)
            {
                Console.WriteLine("?");
            }
            else if (ptn1)
            {
                Console.WriteLine("+");
            }
            else if (ptn2)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("!");
            }
        }
    }
}