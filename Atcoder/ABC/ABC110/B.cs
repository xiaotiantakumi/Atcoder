using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC110
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var nmxy = ReadIntArray();
            var condX = ReadIntArray().Max();
            var condY = ReadIntArray().Min();
            for (int i = nmxy[2] + 1; i <= nmxy[3]; i++)
            {
                if (condX < i &&
                    condY >= i)
                {
                    Console.WriteLine("No War");
                    return;
                }
            }

            Console.WriteLine("War");
        }
    }
}