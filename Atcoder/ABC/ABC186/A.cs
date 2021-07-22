using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC186
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(r[0] / r[1]);
        }
    }
}