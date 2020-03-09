using System;

namespace Atcoder.ABC074
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var K = ReadInt();
            var xs = ReadIntArray();
            int ret = 0;
            for (int i = 0; i < xs.Length; i++)
            {
                ret += Math.Min(xs[i] * 2, ((K - xs[i]) * 2));
            }

            Console.WriteLine(ret);
        }
    }
}