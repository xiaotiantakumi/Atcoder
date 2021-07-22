using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC012
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(AB[1] + " " + AB[0]);
        }
    }
}