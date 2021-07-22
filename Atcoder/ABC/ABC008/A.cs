using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC008
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ST = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ST[1] - ST[0] + 1);
        }
    }
}