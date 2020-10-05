using System;
using System.Linq;

namespace Atcoder.ABCLike.SoundHound_Inc_Programming_Contest_2018__Masters_Tournament
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (ab[0] * ab[1] == 15)
            {
                Console.WriteLine("*");
            }
            else if (ab[0] + ab[1] == 15)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("x");
            }
        }
    }
}