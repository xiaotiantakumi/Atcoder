using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC018
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var list = new int[3] { A, B, C }.OrderByDescending(_ => _).ToList();
            Console.WriteLine(list.IndexOf(A) + 1);
            Console.WriteLine(list.IndexOf(B) + 1);
            Console.WriteLine(list.IndexOf(C) + 1);
        }
    }
}