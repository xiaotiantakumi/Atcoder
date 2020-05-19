using System;
using System.Linq;

namespace Atcoder.ABC.ABC023
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            Console.WriteLine(int.Parse(r.First().ToString()) + int.Parse(r.Last().ToString()));
        }
    }
}