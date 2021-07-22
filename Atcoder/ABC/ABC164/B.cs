using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC164
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var ABCD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABCD[0];
            var B = ABCD[1];
            var C = ABCD[2];
            var D = ABCD[3];
            bool isTaka = true;
            while (true)
            {
                if (isTaka)
                {
                    C -= B;
                    if (C <= 0)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
                else
                {
                    A -= D;
                    if (A <= 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                isTaka = !isTaka;
            }
        }
    }
}