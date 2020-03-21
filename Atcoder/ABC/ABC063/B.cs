using System;

namespace Atcoder.ABC063
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var S = Read();
            string str = string.Empty;
            foreach (var s in S)
            {
                if (str.Contains(s))
                {
                    Console.WriteLine("no");
                    return;
                }
                str += s.ToString();
            }
            Console.WriteLine("yes");
        }
    }
}