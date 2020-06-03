using System;
using System.Linq;

namespace Atcoder.ABC.ABC169
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            Console.WriteLine(Math.Truncate(r[0] * r[1]));
        }
    }
}