using System;
using CoderCommon;

namespace Atcoder.ABC.ABC178
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(x == 0 ? 1 : 0);
        }
    }
}