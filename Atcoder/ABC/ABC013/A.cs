using System;
using System.Linq;

namespace Atcoder.ABC.ABC013
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var list = "ABCDE".ToList();
            var X = Console.ReadLine();
            Console.WriteLine(list.IndexOf(X.ToCharArray()[0]) + 1);
        }
    }
}