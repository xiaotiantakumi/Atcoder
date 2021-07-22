using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC195
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var MH = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = MH[1] % MH[0] == 0;
            Console.WriteLine(ret ? "Yes" : "No");
        }
    }
}