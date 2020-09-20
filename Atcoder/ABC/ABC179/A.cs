using System;
using System.Linq;

namespace Atcoder.ABC.ABC179
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Last() == 's' ? s + "es" : s + "s");
        }
    }
}