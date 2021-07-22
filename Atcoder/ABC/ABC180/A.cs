using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC180
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(NAB[0] - NAB[1] + NAB[2]);
        }
    }
}