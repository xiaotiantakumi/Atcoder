using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC188
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dif = Math.Abs(r[0] - r[1]);
            Console.WriteLine(dif < 3 ? "Yes" : "No");
        }
    }
}