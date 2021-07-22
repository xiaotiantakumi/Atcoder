using System;
using CoderCommon;

namespace Atcoder.ABC.ABC006
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 3 == 0 ? "YES" : "NO");
        }
    }
}