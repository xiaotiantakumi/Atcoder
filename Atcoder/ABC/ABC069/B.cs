using System;
using System.Linq;

namespace Atcoder.ABC069
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            var len = r.Length - 2;
            Console.WriteLine(r.First().ToString() + len.ToString() + r.Last().ToString());
        }
    }
}