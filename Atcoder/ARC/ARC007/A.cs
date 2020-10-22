using System;
using System.Linq;

namespace Atcoder.ARC.ARC007
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var X = Console.ReadLine();
            var s = Console.ReadLine();
            var ret = s.Where(x => x != X.First()).ToArray();
            Console.WriteLine(new string(ret));
        }
    }
}