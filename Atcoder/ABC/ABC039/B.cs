using System;

namespace Atcoder.ABC039
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = long.Parse(Console.ReadLine());
            var ret = Math.Sqrt(Math.Sqrt(r));
            Console.WriteLine(ret);
        }
    }
}