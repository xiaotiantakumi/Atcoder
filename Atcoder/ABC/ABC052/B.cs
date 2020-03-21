using System;

namespace Atcoder.ABC052
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = ReadInt();
            var S = Read();
            int ret = 0;
            int cal = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'I')
                {
                    ++cal;
                }
                else if (S[i] == 'D')
                {
                    --cal;
                }

                ret = Math.Max(cal, ret);
            }

            Console.WriteLine(ret);
        }
    }
}