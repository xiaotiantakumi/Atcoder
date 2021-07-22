using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC005
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(xy[1] / xy[0]);
        }
    }
}