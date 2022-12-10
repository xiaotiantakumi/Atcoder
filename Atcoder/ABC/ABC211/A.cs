using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC211
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = (AB[0] + 2 * AB[1]) * 1f / 3;
            Console.WriteLine(ret);
        }
    }
}