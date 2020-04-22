using System;
using System.Linq;

namespace Atcoder.ABC.ABC040
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var nx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(nx[0] - nx[1], nx[1] - 1));
        }
    }
}