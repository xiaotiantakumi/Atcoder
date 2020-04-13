using System;
using System.Linq;

namespace Atcoder.ABC038
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            Console.WriteLine(r.Last() == 'T' ? "YES" : "NO");
        }
    }
}