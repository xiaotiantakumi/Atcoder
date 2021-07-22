using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC165
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var K = int.Parse(Console.ReadLine());
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = AB[0]; i <= AB[1]; i++)
            {
                if (i % K == 0)
                {
                    Console.WriteLine("OK");
                    return;
                }
            }

            Console.WriteLine("NG");
        }
    }
}