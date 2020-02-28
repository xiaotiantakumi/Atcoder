using System;

namespace Atcoder.ABC055
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            long ret = 1;
            for (int i = 1; i <= N; i++)
            {
                ret = ret * i % 1000000007;
            }

            Console.WriteLine(ret);
        }
    }
}