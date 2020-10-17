using System;
using System.Linq;

namespace Atcoder.ABC.ABC180
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NAB[0] - NAB[1] + NAB[2]);
        }
    }
}