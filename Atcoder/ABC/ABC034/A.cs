using System;
using System.Linq;

namespace Atcoder.ABC.ABC034
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(xy[0] < xy[1] ? "Better" : "Worse");
        }
    }
}