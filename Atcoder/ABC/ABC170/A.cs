using System;
using System.Linq;

namespace Atcoder.ABC.ABC170
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var x = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(x.IndexOf(0) + 1);
        }
    }
}