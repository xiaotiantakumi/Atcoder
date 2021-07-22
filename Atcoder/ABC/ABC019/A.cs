using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC019
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var abc = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(abc[1]);
        }
    }
}