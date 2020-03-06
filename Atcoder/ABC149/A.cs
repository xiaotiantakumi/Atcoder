using System;
using System.Linq;

namespace Atcoder.ABC149
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().ToArray();
            Console.WriteLine(r[1] + r[0]);
        }
    }
}