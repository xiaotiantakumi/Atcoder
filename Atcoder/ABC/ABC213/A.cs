using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC213
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = ab[0];
            var b = ab[1];
            for (int i = 0; i <= 255; i++)
            {
                if ((i ^ a) == b)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}