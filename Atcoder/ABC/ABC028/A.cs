using System;
using CoderCommon;

namespace Atcoder.ABC.ABC028
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N <= 59)
            {
                Console.WriteLine("Bad");
            }
            else if (N <= 89)
            {
                Console.WriteLine("Good");
            }
            else if (N <= 99)
            {
                Console.WriteLine("Great");

            }
            else
            {
                Console.WriteLine("Perfect");
            }
        }
    }
}