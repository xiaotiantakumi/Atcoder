using System;
using System.Linq;

namespace Atcoder.ABC.ABC002
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(XY[0], XY[1]));
        }
    }
}