using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC179
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Last() == 's' ? s + "es" : s + "s");
        }
    }
}