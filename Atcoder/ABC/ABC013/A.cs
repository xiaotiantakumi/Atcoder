using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC013
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var list = "ABCDE".ToList();
            var X = Console.ReadLine();
            Console.WriteLine(list.IndexOf(X.ToCharArray()[0]) + 1);
        }
    }
}