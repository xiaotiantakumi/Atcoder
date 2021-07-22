using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC023
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            Console.WriteLine(int.Parse(r.First().ToString()) + int.Parse(r.Last().ToString()));
        }
    }
}