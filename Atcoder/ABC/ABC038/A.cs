using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC038
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            Console.WriteLine(r.Last() == 'T' ? "YES" : "NO");
        }
    }
}