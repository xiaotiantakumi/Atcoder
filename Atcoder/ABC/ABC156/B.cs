using System;

namespace Atcoder.ABC156
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            var N = r[0];
            var K = r[1];

            string ret = string.Empty;
            while (N > 0)
            {
                ret += N % K;
                N /= K;
            }

            Console.WriteLine(ret.Length);
        }
    }
}