using System;

namespace Atcoder.ABC.ABC029
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            int ret = 0;
            for (int i = 0; i < 12; i++)
            {
                var s = Console.ReadLine();
                if (s.Contains('r'))
                {
                    ret++;
                }
            }

            Console.WriteLine(ret);
        }
    }
}