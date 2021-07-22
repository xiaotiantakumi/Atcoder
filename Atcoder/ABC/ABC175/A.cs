using System;
using CoderCommon;

namespace Atcoder.ABC.ABC175
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var S = Console.ReadLine();
            int ret = 0;
            if (S == "RRR")
            {
                Console.WriteLine(3);
            }
            else if (S.Contains("RR"))
            {
                Console.WriteLine(2);
            }
            else if (S.Contains("R"))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}