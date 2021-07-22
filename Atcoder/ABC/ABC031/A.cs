using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC031
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var AD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var small = Math.Min(AD[0], AD[1]) + 1;
            var big = Math.Max(AD[0], AD[1]);

            Console.WriteLine(small * big);
        }
    }
}