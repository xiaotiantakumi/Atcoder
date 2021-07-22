using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC040
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var nx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(nx[0] - nx[1], nx[1] - 1));
        }
    }
}