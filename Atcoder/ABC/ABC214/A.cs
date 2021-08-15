using System;
using CoderCommon;

namespace Atcoder.ABC.ABC214
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = int.Parse(Console.ReadLine());
            if (N < 126)
            {
                Console.WriteLine(4);
            }
            else if (N < 212)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(8);
            }
        }
    }
}