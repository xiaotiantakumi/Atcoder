using System;
using System.Linq;

namespace Atcoder.ABC.ABC193
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine((1 - AB[1] / AB[0]) * 100);
        }
    }
}