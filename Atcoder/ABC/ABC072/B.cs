using System;

namespace Atcoder.ABC072
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            string ret = string.Empty;
            for (int i = 0; i < r.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    ret += r[i].ToString();
                }
            }
            Console.WriteLine(ret);
        }
    }
}