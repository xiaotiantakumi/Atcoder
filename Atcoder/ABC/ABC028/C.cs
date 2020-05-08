using System;
using System.Linq;

namespace Atcoder.ABC.ABC028
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(r[0] + r[3] + r[4], r[1] + r[2] + r[4]));
        }
    }
}