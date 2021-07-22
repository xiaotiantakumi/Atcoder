using System;
using CoderCommon;

namespace Atcoder.ABC.ABC174
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var X = int.Parse(Console.ReadLine());
            if (X >= 30)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}