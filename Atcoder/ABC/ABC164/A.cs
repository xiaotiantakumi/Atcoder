using System;
using System.Linq;

namespace Atcoder.ABC.ABC164
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var SW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(SW[0] <= SW[1] ? "unsafe" : "safe");
        }
    }
}