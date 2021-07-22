using System;
using CoderCommon;

namespace Atcoder.ABC.ABC162
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var N = Console.ReadLine();
            foreach (var item in N)
            {
                if (item == '7')
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}