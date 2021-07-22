using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC002
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(XY[0], XY[1]));
        }
    }
}